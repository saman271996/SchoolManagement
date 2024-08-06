using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using SchoolManagement.ViewModel;
using SchoolManagement.HelperClasses;
using System.Web.Mvc;
using System.Web.Helpers;
using SchoolManagement.Model;
using System.Xml;
using SchoolManagement.Helper;

namespace SchoolManagement
{
    public partial class Registration : Form
    {
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        validations validates = new validations();
        Form frm;
        public Registration()
        {

            InitializeComponent();

        }


        private void SchoolRegister_Click(object sender, EventArgs e)
        {
 
            var message = "";
            loadingImage.Visible = true;
            try
            {
                var randomno = new Random();
                if (SchoolName.Text.Trim().Length < 3 && PhoneNumber.Text.Trim().Length != 10)
                {
                    loadingImage.Visible = false;
                    MessageBox.Show("Please School Name and it should be more than 2 in length and check your mobile no. is correct is it in length of 10");
                    if(SchoolName.Text.Length < 3)
                    {
                        SchoolName.StateCommon.Border.Color1 = Color.Red;
                        SchoolName.Focus();
                    }
                    if(PhoneNumber.Text.Length!=10)
                    {
                        PhoneNumber.StateCommon.Border.Color1 = Color.Red;
                        PhoneNumber.Focus();
                    }
                    
                    return;
                }
                var unique = SchoolName.Text.Substring(0, 2) + "_" + PhoneNumber.Text.Substring(0,4) + "_" + randomno.Next(0, 1000000000) + randomno.Next(0, 800000000);
                var schooldetails = new SchoolDetail
                {
                    UserType = 0,
                    Pan = PanNumber.Text,
                    SchoolGst = SchoolGstNumber.Text,
                    SchoolName = SchoolName.Text,
                    SchoolAddress = SchoolAddress.Text,
                    Email = Email.Text,
                    Name = Name.Text,
                    Phone = PhoneNumber.Text,
                    SchoolWebsite = SchoolWebsite.Text,
                    PlanId = 1,
                    PlanDays = 5,
                    PlanExpiryDate = DateTime.Now.AddDays(5),
                    NumberOfUsers = 3,
                    PlanAmount = 0,  // providing free trial having planamount 0 which can be changed by owner
                    IsOtpVarified = false,
                    IsActive = true,
                    IsDelete = false,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                    Password = unique,
                    //CompanyUID=Guid.NewGuid(),
                };

                var messages_register = validates.ValidateRegister(schooldetails);
                if (messages_register.Status == true)
                {
                    loadingImage.Visible = false;
                    MessageBox.Show(messages_register.Message);
                    if(messages_register.Text == "Email")
                    {
                        Email.StateCommon.Border.Color1 = Color.Red;
                        Email.Focus();
                    }
                    else if (messages_register.Text == "Pan")
                    {
                        PanNumber.StateCommon.Border.Color1 = Color.Red;
                        PanNumber.Focus();
                    }
                    else if (messages_register.Text == "SchoolName")
                    {
                        SchoolName.StateCommon.Border.Color1 = Color.Red;
                        SchoolName.Focus();
                    }
                    else if (messages_register.Text == "SchoolWebsite")
                    {
                        SchoolWebsite.StateCommon.Border.Color1 = Color.Red;
                        SchoolWebsite.Focus();
                    }
                    
                    return;
                }
                else
                {
                    if (!Db.SchoolDetails.Any(x => x.Email == Email.Text && x.Phone == PhoneNumber.Text && x.IsActive == true))
                    {
                        if (!Db.Users.Any(x => x.Email == Email.Text && x.PhoneNumber == PhoneNumber.Text && x.IsActive == true))
                        {

                            Db.SchoolDetails.Add(schooldetails);
                            Db.SaveChanges();

                            var newUser = new User
                            {
                                UserName = Name.Text,
                                Email = Email.Text,
                                PhoneNumber = PhoneNumber.Text,
                                SchoolUser = 0,//Admin user 
                                //MenuRights = Globals.DefaultMenuRights,
                                UserType = 0,
                                IsActive = true,
                                IsDelete = false,
                                ForgotPasswordCode = Guid.NewGuid().ToString("n"),
                                DateAdded = DateTime.Now,
                                DateModified = DateTime.Now,
                                OTPCode = ExtensionMethod.RandomNumber(6),
                                IsOTPVerified = false,
                                OTPVerifiedValidDate = DateTime.Now.AddHours(2),
                                Password=unique,
                                SchoolId= schooldetails.Id
                            };
                            Db.Users.Add(newUser);
                            Db.SaveChanges();



                            #region data entry for subscription history details
                            var userSubscriptionDetail = new UserSubscriptionPlanDetail
                            {
                                SchoolId = schooldetails.Id,
                                UserId = newUser.UserId,
                                PlanId = 1, // trail plan 
                                UserEmailId = Email.Text,
                                UserName = $"{Name.Text}",
                                Amount = 0,
                                TransactionID = "Free",
                                ExpiryDate = DateTime.Now.AddDays(5),// free trail for 5 days
                                IsActive = true,
                                IsDelete = false,
                                DateAdded = DateTime.Now,
                            };

                            Db.UserSubscriptionPlanDetails.Add(userSubscriptionDetail);
                            Db.SaveChanges();

                            #endregion

                            //SessionHandler.TempUserId = newUser.Id;
                            if (!string.IsNullOrEmpty(newUser.Email))
                            {
                                var dbUser = Db.Users.FirstOrDefault(x => x.UserId == newUser.UserId);
                                dbUser.IsOTPVerified = true;
                                //Db.Entry(dbUser).State = EntityState.Modified;
                                Db.SaveChanges();

                                var responsestring = "<html>\r\n<head>\r\n <meta charset=\"utf-8\" />\r\n<title>Generate Password </title>\r\n <link href=\"https://fonts.googleapis.com/css?family=Roboto:300,300i,400,400i,500,500i,700\" rel=\"stylesheet\">\r\n<style>\r\nbody {\r\nfont-family: 'Roboto', serif;\r\n            font-weight: 500;\r\n}\r\n    </style>\r\n</head>\r\n<body style=\"margin:0;\">\r\n    <table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"700\" align=\"center\" style=\"\">\r\n<tbody>\r\n<tr>\r\n<td style=\"text-align: center; padding: 5px 0;\">\r\n<img src=\"https://.SinghTek.com/images/logo.png\" alt=\"\" style=\"width: 180px; text-align: center;\">\r\n</td>\r\n </tr>\r\n <tr>\r\n<td>\r\n<table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"700px\">\r\n <tbody>\r\n<tr>\r\n<td width=\"56\"></td>\r\n<td bgcolor=\"#ffffff\">\r\n<table cellpadding=\"25\" cellspacing=\"0\" border=\"0\" width=\"100%\" style=\"font-size:14px;\">\r\n                       <tbody>\r\n <tr>\r\n<td style=\"color:#121212;border-top: 6px solid #0882cf;\">\r\n<p style=\"padding:0px;margin:0px;line-height:20px;padding-bottom:10px; font-weight:bold; color:#0882cf;\">Hi " + Name.Text + "<span id=\"name\"></span></p>\r\n  <p style=\"padding:0px;margin:0px;line-height:20px\">Your registration is successfull in SinghTek ,Your Password is " + unique + "  <span class=\"il\">now you can create your password also</span>  by click on  this button. </p>\r\n<p align=\"center\" style=\"padding:0px;margin:0px;padding-top:20px\">\r\n <a href=\"@url\" target=\"_blank\" class=\"pressed\" style=\"text-decoration:none; display: inline-block;padding: 10px 25px;cursor: pointer;text-align: center;text-decoration: none;outline: none;color: #fff;background:#0882cf;-moz-border-radius: 50px; -webkit-border-radius: 50px;-khtml-border-radius: 50px;border-radius: 50px; font-size:16px;\">Create Password</a>\r\n</p>\r\n<p style=\"margin:25px 0 25px;\">If you did not request a create password, please ignore this email or reply to let us know. This link only valid for the next 24 hours, so be sure to use it right away.</p>\r\n <p>If you're having trouble clicking the password create, copy and paste the URL below into your web browser.</p>\r\n<a href=\"@url\" style=\"color:#0882cf; word-break: break-all; width: 90%;display: block;\">@url</a>\r\n<p style=\"margin:20px 0 0; font-size:15px\">Thanks</p>\r\n<p style=\"margin: 5px 0 5px;padding: 0 0 5px; font-size:15px\">SinghTek Team</p>\r\n</td>\r\n</tr>\r\n </tbody>\r\n </table>\r\n</td>\r\n <td width=\"56\"></td>\r\n</tr>\r\n <tr>\r\n<td width=\"56\"></td>\r\n<td>\r\n<p style=\"padding:1px 10px; background:#0882cf; margin: 0;\"></p>\r\n<p style=\"text-align: center; margin: 10px 0 0;\">\r\n<small>\r\nThis is web based solution for manage your business & organization.\r\n You have received this mail because your e-mail (<a href=\"mailto:@Model.Email\">@Model.Email</a>) is registered withSinghTek & this mail generate from SinghTek account. If you think this is SPAM, Please report to <a href=\"mailto:info@SinghTek.com\">info@SinghTek.com</a> for immediate action.\r\n</small>\r\n </p>\r\n<p style=\"text-align: center; margin-top: 5px;\"><small></small></p>\r\n</td>\r\n <td width=\"56\"></td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n </tbody>\r\n </table>\r\n</body>\r\n</html>";
                                System.Threading.Tasks.Task.Factory.StartNew(() => SchoolManagement.HelperClasses.UserMailer.SendEmailByMaster(Email.Text, "Generate your password", responsestring));

                                //var mailer = new SchoolViewModel { Name=Name.Text, Email = newUser.Email, Code = newUser.ForgotPasswordCode };



                                //var adminmailer = new CommonFunctions().GetModelForMail();
                                //var regStringHtml = this.RenderView("~/Views/UserMailer/Registration.cshtml", adminmailer);
                                //System.Threading.Tasks.Task.Factory.StartNew(() => UserMailer.SendEmailByMaster(adminmailer.Email, "CRM Signup", regStringHtml));
                                loadingImage.Visible = false;
                                message = "Success,Create Password link has been sent to your Email Address,success";
                                MessageBox.Show("Successfully added record,registration has been done!,Password has been sent to your mail id and you can change your password link has been send.");
                                
                                this.Hide();
                                frm = new Login();
                                frm.Show();
                            }

                        }
                        else
                        {
                            loadingImage.Visible = false;
                            MessageBox.Show("Already user is created");
                            return;
                        }
                    }
                    else
                    {
                        loadingImage.Visible = false;
                        MessageBox.Show("Already school is registered");
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                loadingImage.Visible = false;
                message = "Something went wrong,if problem occurs continue,please contact to Signhtek!";
                MessageBox.Show("Something went wrong,it can be internet issue also please check your internet properly,if problem occurs continue,please contact to Signhtek!");
                return;
            }

}
public SchoolViewModel SendEmaildataGeneratePassword()
{
    SchoolViewModel schdetail = new SchoolViewModel();
    schdetail.Name = "Aman";

    return schdetail;
}

        private void Registration_Load(object sender, EventArgs e)
        {
            loadingImage.Visible=false;
        }
    }
}
