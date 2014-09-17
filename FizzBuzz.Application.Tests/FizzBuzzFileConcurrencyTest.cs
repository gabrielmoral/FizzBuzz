using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Application;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace FizzBuzz.Application.Tests
{
    [TestClass]
    public class FizzBuzzFileConcurrencyTest
    {
        private string path = @"c:\FizzBuzzResults.txt";
        
        private Mock<IAppSettingsRepository> appSettingsRepositoryMock;

        [TestInitialize]
        public void Init()
        {
            appSettingsRepositoryMock = new Mock<IAppSettingsRepository>();

            appSettingsRepositoryMock.Setup(x => x.GetLimitValue())
                                     .Returns(3);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        [TestMethod]
        public void The_File_Is_Created_When_FizzBuzzFile_Is_Called()
        {
            IFizzBuzzFileRepository fizzBuzzFileRepository = new FizzBuzzFileRepository();

            FizzBuzzFile fizzBuzzFile = new FizzBuzzFile(fizzBuzzFileRepository, appSettingsRepositoryMock.Object);

            fizzBuzzFile.SetResultsInFile(3);

            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void File_Has_One_Line_When_FizzBuzzFile_Is_Called()
        {
            IFizzBuzzFileRepository fizzBuzzFileRepository = new FizzBuzzFileRepository();

            FizzBuzzFile fizzBuzzFile = new FizzBuzzFile(fizzBuzzFileRepository, appSettingsRepositoryMock.Object);

            fizzBuzzFile.SetResultsInFile(3);

            Assert.AreEqual(1, File.ReadLines(path).Count());
        }
    }
}