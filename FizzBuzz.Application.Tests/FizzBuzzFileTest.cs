using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Application;
using Moq;
using System.Collections.Generic;

namespace FizzBuzz.Application.Tests
{
    [TestClass]
    public class FizzBuzzFileTest
    {
        private Mock<IFizzBuzzFileRepository> fizzBuzzFileRepositoryMock;
        private Mock<IAppSettingsRepository> appSettingsRepositoryMock;

        [TestInitialize]
        public void Init()
        {
            fizzBuzzFileRepositoryMock = new Mock<IFizzBuzzFileRepository>();
            appSettingsRepositoryMock = new Mock<IAppSettingsRepository>();
        }

        [TestMethod]
        public void Create_Fizz_Buzz_File_Is_Called_When_There_Is_Results()
        {
            appSettingsRepositoryMock.Setup(x => x.GetLimitValue())
                                     .Returns(1);

            FizzBuzzFile fizzBuzzFile = new FizzBuzzFile(fizzBuzzFileRepositoryMock.Object, appSettingsRepositoryMock.Object);

            fizzBuzzFile.SetResultsInFile(3);

            fizzBuzzFileRepositoryMock.Verify(x => x.Save(new List<string>() { "fizz" }), Times.Once);
        }

        [TestMethod]
        public void Create_Fizz_Buzz_File_Is_Not_Called_When_There_Is_Not_Results()
        {
            appSettingsRepositoryMock.Setup(x => x.GetLimitValue())
                                     .Returns(0);

            FizzBuzzFile fizzBuzzFile = new FizzBuzzFile(fizzBuzzFileRepositoryMock.Object, appSettingsRepositoryMock.Object);

            fizzBuzzFile.SetResultsInFile(3);

            fizzBuzzFileRepositoryMock.Verify(x => x.Save(null), Times.Never);
        }
    }
}