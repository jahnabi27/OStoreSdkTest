using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ziroh.FileSystem;
using Ziroh.FileSystem.Activities.Common;
using Ziroh.FileSystem.OperationResults;
using Ziroh.Misc.Common;

namespace UserManagementUnitTest
{
    [TestClass]
    public class FileSystemTestFiles
    {
        FileSystemClient client;
        Activity activity;
        ItemId[] items;
        private string rootDirectoryId = "057441C3D17070D434777B42583AA22AD2210B2C1FE37466214C9C6C07F6FBF11E1189D905727A9C5A2315A97E6B6476F78651853AB4C914EED903D91851A6D2";
        public FileSystemTestFiles() {
            this.client = new FileSystemClient();
            this.activity = new Activity();
            this.items = new ItemId[1];
        }

        [TestMethod]
        public void acceptSharedDirectory()
        {
            string accept_dir = "71587EF045970546D367E12D26F9F35FF38B63B64A4F8023CE8ED969920E6318B1AFB6187A1C8525B73C147DED1378F611E2A3B7A199D01ECBDA9E212FF7BCCE";
           Result result = client.AcceptSharedDirectory(accept_dir).GetAwaiter().GetResult();
            Assert.AreEqual(0,result.error_code,result.error_message);
        }
        [TestMethod]
        public void acceptSharedFile()
        {
            string fileId = "BA7FBF2720B965F8D1B31525AE9FBE93BD435C6217A5A32BCFE2A994FFE594105586F215ACAF21E65474C75E74133CD86C6E3C958FFEAA5E2D26506BEEF27030";
            Result result = client.AcceptSharedFile(fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void addSystemDirectory()
        {
            string directoryPath = "C:\\Users\\User\\Desktop\\algorithms101-master\\File Types";
            DirectoryCreationResult result = client.AddSystemDirectory(directoryPath,rootDirectoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void addSystemFile()
        {
            string filePath = "C:\\Users\\User\\Desktop\\algorithms101 - master\\File Types\\download.jpg";
          
            FileCreationResult result = client.AddSystemFile(filePath,rootDirectoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void createNewDirectory()
        {
            string directoryName = "PranjalPersonal";
            DirectoryCreationResult result = client.CreateNewDirectory(directoryName,rootDirectoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void createRoot()
        {
            DirectoryCreationResult result = client.CreateRoot().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void deleteActivity()
        {
            string fileId = "0E005597D150C8128E3228E9A65C26D346DDD45210A1792594A31049105FAE1D83448CDF978F935C4B405259597DD218A2BB49FBD7E627DB34E2F9463079AF71";
            Result result = client.DeleteActivity(fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void deleteDirectory()
        {
            string directoryId = "1FF88F8FDE433E2F280F4F1215C9180D25142ADCFB57CDB4B195D5B4A761D3E0BAB9440ECBC8C93D50EC90EF007BA351376D231CD587D3D7A56B342426354692";
            DirectoryDeletionResult result = client.DeleteDirectory(directoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void deleteFile()
        {
            string fileId = "0E005597D150C8128E3228E9A65C26D346DDD45210A1792594A31049105FAE1D83448CDF978F935C4B405259597DD218A2BB49FBD7E627DB34E2F9463079AF71";
            FileDeletionResult result = client.DeleteFile(fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void deleteSharedDirectory()
        {
            string directoryId = "67900DCD5CA8C8634953BA8DCF3F2E19C9694E3D07E23836D883490F2DFE4AA428BBC4F8B6107F8A969551AEF063EBBD0EE6A7E5E9CC22C7652F47F6B303B56E";
            DirectoryDeletionResult result = client.DeleteSharedDirectory(directoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void deleteSharedFile()
        {
            string fileId = "00EF5A9502FA1C4CD327CFE524AF419D64E9DEA93EF2F04D40B919AA8E8BF5CF87922161995344F40FA0E95656D5636C59F07B9E92FEEAB1E358F7DB4F835F8F";
            SharedFileDeleteResult result = client.DeleteSharedFile(fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void downloadDirectory()
        {
            string directoryId = "1FF88F8FDE433E2F280F4F1215C9180D25142ADCFB57CDB4B195D5B4A761D3E0BAB9440ECBC8C93D50EC90EF007BA351376D231CD587D3D7A56B342426354692";
            DirectoryDownloadResult result = client.DownloadDirectory(directoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void downloadFile()
        {
            string fileId = "F8213DA8A1D62B0B7A517D1B15429DE1AD12A0DF40009CDBD2F8F1064FAB90BBA536CAA735816A3658533C56B8E6877BB0A9FAE96F48A9E7E71143DCF61C7CD4";
            FileDownloadResult result = client.DownloadFile(fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void downloadSharedDirectory()
        {
            string directoryId = "67900DCD5CA8C8634953BA8DCF3F2E19C9694E3D07E23836D883490F2DFE4AA428BBC4F8B6107F8A969551AEF063EBBD0EE6A7E5E9CC22C7652F47F6B303B56E";
            DirectoryDownloadResult result = client.DownloadSharedDirectory(directoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void downloadSharedFile()
        {
            string fileId = "00EF5A9502FA1C4CD327CFE524AF419D64E9DEA93EF2F04D40B919AA8E8BF5CF87922161995344F40FA0E95656D5636C59F07B9E92FEEAB1E358F7DB4F835F8F";
            FileDownloadResult result = client.DownloadSharedFile(fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void getRecyclebin()
        {
            DirectoryRetreivalResult result = client.GetRecycleBin().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void getRoot()
        {
            DirectoryRetreivalResult result = client.GetRoot().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void getSharedDirectory()
        {
            DirectoryRetreivalResult result = client.GetSharedDirectory().GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void listAllActivities()
        {
            string fileId = "F8213DA8A1D62B0B7A517D1B15429DE1AD12A0DF40009CDBD2F8F1064FAB90BBA536CAA735816A3658533C56B8E6877BB0A9FAE96F48A9E7E71143DCF61C7CD4";
             client.ListAllActivities(fileId).GetAwaiter().GetResult();
        }
        [TestMethod]
        public void listAllActivitiesPage()
        {
            string fileId = "F8213DA8A1D62B0B7A517D1B15429DE1AD12A0DF40009CDBD2F8F1064FAB90BBA536CAA735816A3658533C56B8E6877BB0A9FAE96F48A9E7E71143DCF61C7CD4";
            int start_offset = 0;
            int max_count = 6;
           client.ListAllActivitiesPage(fileId,start_offset,max_count).GetAwaiter().GetResult();
        }
        [TestMethod]
        public void moveDirectory()
        {
            string directoryId = "1FF88F8FDE433E2F280F4F1215C9180D25142ADCFB57CDB4B195D5B4A761D3E0BAB9440ECBC8C93D50EC90EF007BA351376D231CD587D3D7A56B342426354692";
            string directoryId1 = "67900DCD5CA8C8634953BA8DCF3F2E19C9694E3D07E23836D883490F2DFE4AA428BBC4F8B6107F8A969551AEF063EBBD0EE6A7E5E9CC22C7652F47F6B303B56E";
            DirectoryMoveResult result = client.MoveDirectory(directoryId1,directoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void moveFile()
        {
            string directoryId = "1FF88F8FDE433E2F280F4F1215C9180D25142ADCFB57CDB4B195D5B4A761D3E0BAB9440ECBC8C93D50EC90EF007BA351376D231CD587D3D7A56B342426354692";
            string fileId = "0E005597D150C8128E3228E9A65C26D346DDD45210A1792594A31049105FAE1D83448CDF978F935C4B405259597DD218A2BB49FBD7E627DB34E2F9463079AF71";
            FileMoveResult result = client.MoveFile(fileId,directoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void postActivity()
        {
            activity.ActivityID = 5;
            activity.ActivityName = "pranjal";
            activity.ActivityTime = Double.Parse(System.DateTime.Now.ToString());
            string fileId = "BA7FBF2720B965F8D1B31525AE9FBE93BD435C6217A5A32BCFE2A994FFE594105586F215ACAF21E65474C75E74133CD86C6E3C958FFEAA5E2D26506BEEF27030";
            Result result = client.PostActivity(activity,fileId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void renameDirectory()
        {
            string directoryId = "1FF88F8FDE433E2F280F4F1215C9180D25142ADCFB57CDB4B195D5B4A761D3E0BAB9440ECBC8C93D50EC90EF007BA351376D231CD587D3D7A56B342426354692";
            string new_directory_name = "newDir";
            Result result = client.RenameDirectory(directoryId,new_directory_name).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void renameFile()
        {
            string fileId = "F8213DA8A1D62B0B7A517D1B15429DE1AD12A0DF40009CDBD2F8F1064FAB90BBA536CAA735816A3658533C56B8E6877BB0A9FAE96F48A9E7E71143DCF61C7CD4";
            string newFileName = "";
            Result result = client.RenameFile(fileId,newFileName).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void restoreAllFromRecycleBin()
        {
            items[0].Id = "6BD67874B87A1269FCB7B6C6841BE2F77749F81DE0764EE9E4C3BBB5DA389762FDEBA70576ADA7008C6969BD47CB79E4B5697D68E4A4F08A87236ACBF8E157E7";
            RestoreFileResult result = client.RestoreAllFromRecycleBin(items).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void retrieveDirectory()
        {
            //root
            DirectoryRetreivalResult result = client.RetreiveDirectory(rootDirectoryId).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void sharedDirectory()
        {
            string directoryId = "67900DCD5CA8C8634953BA8DCF3F2E19C9694E3D07E23836D883490F2DFE4AA428BBC4F8B6107F8A969551AEF063EBBD0EE6A7E5E9CC22C7652F47F6B303B56E";
            string[] users = { "5325009707BDB3851B940AA72847E626BD213CE33AE72AAF33191AD0170DAC79" };
            DirectoryShareResult result = client.ShareDirectory(directoryId,users).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void shareFile()
        {
            string fileId = "BA7FBF2720B965F8D1B31525AE9FBE93BD435C6217A5A32BCFE2A994FFE594105586F215ACAF21E65474C75E74133CD86C6E3C958FFEAA5E2D26506BEEF27030";
            string[] users = { "5325009707BDB3851B940AA72847E626BD213CE33AE72AAF33191AD0170DAC79" };
            FileShareResult result = client.ShareFile(fileId,users).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void unShareDirectory()
        {
            string directoryId = "67900DCD5CA8C8634953BA8DCF3F2E19C9694E3D07E23836D883490F2DFE4AA428BBC4F8B6107F8A969551AEF063EBBD0EE6A7E5E9CC22C7652F47F6B303B56E";
            string[] users = { "5325009707BDB3851B940AA72847E626BD213CE33AE72AAF33191AD0170DAC79" };
            DirectoryDeletionResult result = client.UnShareDirectory(directoryId,users).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
        [TestMethod]
        public void unShareFile()
        {
            string fileId = "BA7FBF2720B965F8D1B31525AE9FBE93BD435C6217A5A32BCFE2A994FFE594105586F215ACAF21E65474C75E74133CD86C6E3C958FFEAA5E2D26506BEEF27030";
            string[] users = { "5325009707BDB3851B940AA72847E626BD213CE33AE72AAF33191AD0170DAC79" };
            FileUnShareResult result = client.UnShareFile(fileId,users).GetAwaiter().GetResult();
            Assert.AreEqual(0, result.error_code, result.error_message);
        }
    }
}
