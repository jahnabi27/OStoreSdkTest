using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ziroh.Misc.Common;
using Ziroh.UserManagement;

namespace OStoreSDKUnitTest

{
    [TestClass]
    public class UserManagementTestFiles
    {
        private string userId = "UserKaliabor";
        private string pass = "UserKC321*";  
        UserProfile user_Profile;
        UserManagementClient client;
        public UserManagementTestFiles() { 
        this.client = new UserManagementClient();
        this.user_Profile = new UserProfile(); 
        }
        
        [TestMethod]
        public void addNewContact()
        {
            string userId = "EB68F27C940D51DA64F97E5019A2750CF564766A554198A202262B321613B984";
            Result result = client.AddNewContact(userId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code,result.error_message);
        }
        [TestMethod]
        public void checkUserType()
        {
            Result result = client.CheckUserType().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }

        [TestMethod]
        public void deleteUser()
        {
            string userId = "DDF5114DB0D43B21A945DE607E2C2C2DA3544FFCC0E7A20B6E0281383439BFF8";
            Result result = client.DeleteUser(userId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        
        [TestMethod]
        public void getAllContacts()
        {
             client.GetAllContacts().GetAwaiter().GetResult();
        
        }

        [TestMethod]
        public void getContact()
        {
            client.GetContact(userId).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void getId()
        {
           string result = client.GetMyID().GetAwaiter().GetResult();
        }

        [TestMethod]
        public void getMyKeys()
        {
           client.GetMyKeys().GetAwaiter().GetResult();
        }


        [TestMethod]
        public void getProfile()
        {
            client.GetProfile().GetAwaiter().GetResult();

        }
        [TestMethod]
        public void migrateFromPasswordless()
        {
            string filePath = "";
            Result result = client.MigrateFromPasswordless(filePath, pass).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }

        [TestMethod]
        public void migrateToPasswordless()
        {
            string filePath = "";
            Result result = client.MigrateToPasswordless(filePath, pass).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }

        [TestMethod]
        public void passwordlessUserSignIn()
        {
            string filePath = "";
            Result result = client.PasswordlessUserSignIn(userId, filePath).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void passwordlessUserSignUp()
        {
            string filePath = "";
            Result result = client.PasswordlessUserSignUp(userId, filePath).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void PaswordlessDeleteUser()
        {
            string filePath = "";
            Result result = client.PaswordlessDeleteUser(userId, filePath).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void removeExistingContact()
        {
            string userId = "EB68F27C940D51DA64F97E5019A2750CF564766A554198A202262B321613B984";
            Result result = client.RemoveExistingContact(userId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void searchForUsers()
        {
            string[] searchItems = { "DDF5114DB0D43B21A945DE607E2C2C2DA3544FFCC0E7A20B6E0281383439BFF8" };
            SearchUserListResult result = client.SearchForUsers(searchItems).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void signIn()
        {
            Result result = client.SignIn(userId, pass).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void signOut()
        {
            Result result = client.SignOut().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void signUp()
        {
            Result result = client.SignUp(userId, pass).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void updateProfile()
        {
            user_Profile.AvatarID = "DDF5114DB0D43B21A945DE607E2C2C2DA3544FFCC0E7A20B6E0281383439BFF8" ;
            user_Profile.AvatarVisible = true;
            user_Profile.EmailID = "jahnabi@gmail.com";
            user_Profile.EmailIDVisible = true;
            user_Profile.FirstName = "Jahnabi";
            user_Profile.LastName = "Sharma";
            user_Profile.NameVisible = true;
            Result result = client.UpdateProfile(user_Profile, pass).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        
    }
}
