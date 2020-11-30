using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ziroh.CloudStore;
using Ziroh.CloudStore.IO.Migration;
using Ziroh.CloudStore.Scheduler.ExtendedScheduler;
using Ziroh.Misc.Common;

namespace UserManagementUnitTest
{
    [TestClass]
    public class UserCloudAccountTestFiles
    {
        CloudStoreClient client;
        NewCloudAccountCredentials credentials;
        
       public UserCloudAccountTestFiles() {
            this.credentials = new NewCloudAccountCredentials();
            this.client = new CloudStoreClient();              
        }
        //not required
        [TestMethod]
        public void addCloudFilter()
        {
            SchedulerFilter[] schedulerFilter = new SchedulerFilter[1];
            schedulerFilter[0].CloudName = "gdrive";
            schedulerFilter[0].ContextmimePair.FileMimeType = "img";
            schedulerFilter[0].ContextmimePair.FileContext = "g";
            schedulerFilter[0].InputTripletId = "iminput";
            SchedulerAddCloudResult schedulerAddCloud = client.AddCloudFilter(schedulerFilter).GetAwaiter().GetResult();
            Assert.AreEqual(0,schedulerAddCloud.error_code,schedulerAddCloud.error_message);
        }
        [TestMethod]
        public void addCloudStore()
        {
           
            credentials.UniqueId = "myGDrive";
            credentials.CloudName = "gdrive";
            Result result = client.AddCloudStore(credentials).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void getAllAddedStores()
        {
            client.GetAllAddedStores().GetAwaiter().GetResult();
        }
        //not required
        [TestMethod]
        public void getAllSchedulerFilterData()
        {
             client.GetAllSchedulerFilterData().GetAwaiter().GetResult();
        }
        [TestMethod]
        public void getAllSchedulerFilterDataMax()
        {

            int offset = 0;
            int count = 6;
            client.GetAllSchedulerFilterDataMax(offset,count).GetAwaiter().GetResult();
        }
        [TestMethod]
        public void getAllSupportedCloud()
        {
            client.GetAllSupportedCloud().GetAwaiter().GetResult();
        }
        //not required
        [TestMethod]
        public void listCloudItems()
        {
            string cloudAccName = "gdrive";
            string id = "EB68F27C940D51DA64F97E5019A2750CF564766A554198A202262B321613B984";
            int maxSize = 5;
            bool isContinue = false;
            ListCloudItemsResult result = client.ListCloudItems(cloudAccName,id,maxSize,isContinue).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        //not required
        [TestMethod]
        public void migrateToCloud()
        {
            string fileId = "BA7FBF2720B965F8D1B31525AE9FBE93BD435C6217A5A32BCFE2A994FFE594105586F215ACAF21E65474C75E74133CD86C6E3C958FFEAA5E2D26506BEEF27030";
            int option = 1;
            Result result = client.MigrateToCloud(fileId,option).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        //not required
        [TestMethod]
        public void migrateToOtose()
        {
            string cloudAccountName = "mydrive";
            string oStoreDestinationId = "";
            string fileOrDirectoryId = "";
            string parentId = "";
            Result result = client.MigrateToOStor(cloudAccountName,oStoreDestinationId,fileOrDirectoryId,parentId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void removeAllCloud()
        {
            Result result = client.RemoveAllCloud().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        //not required
        [TestMethod]
        public void removeCloudFilter()
        {
            string tripletId = "";
            SchedulerRemoveCloudResult schedulerRemoveCloudResult = client.RemoveCloudFilter(tripletId).GetAwaiter().GetResult();
            Assert.AreEqual(0, schedulerRemoveCloudResult.error_code, schedulerRemoveCloudResult.error_message);
        }
        [TestMethod]
        public void removeNonWorkingCloud()
        {
            string accountUniqueId = "mydrive";
            Result result = client.RemoveNonWorkingCloud(accountUniqueId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void removeWorkingCloud()
        {
            string accountUniqueId = "mydrive";
            Result result = client.RemoveWorkingCloud(accountUniqueId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        //not required
        [TestMethod]
        public void tryGetCloud()
        {
            string region = "";
            client.TryGetCloud(region).GetAwaiter().GetResult();
        }
        //not required
        [TestMethod]
        public void tryGetCloudRegion()
        {
            client.TryGetCloudRegions().GetAwaiter().GetResult();
        }
        //not required
        [TestMethod]
        public void updateCloudFilter()
        {
            SchedulerFilter schedulerFilter = new SchedulerFilter();
            schedulerFilter.CloudName = "gdrive";
            schedulerFilter.ContextmimePair.FileMimeType = "img";
            schedulerFilter.ContextmimePair.FileContext = "";
            schedulerFilter.InputTripletId = "";
            SchedulerUpdateCloudResult schedulerUpdateCloudResult = client.UpdateCloudFilter(schedulerFilter).GetAwaiter().GetResult();
            Assert.AreEqual(0, schedulerUpdateCloudResult.error_code, schedulerUpdateCloudResult.error_message);
        }
        //not required
        [TestMethod]
        public void validateMimeType()
        {
            string mimetype = "img";
            Result result = client.ValidateMimeType(mimetype).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }

    }
}
