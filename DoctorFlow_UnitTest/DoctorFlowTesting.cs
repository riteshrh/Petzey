using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using DoctorFlow_Data.Data;
using DoctorFlow_Data.Entities;
using DoctorFlow_Business.DoctorBusiness;
using DoctorFlow_Data.Migrations;

namespace DoctorFlow_UnitTest
{
    [TestClass]
    public class DoctorFlowTesting
    {
        [TestMethod]
        public void AddDoctorSuccessTest()
        {
            var _repoMock = new Mock<IDoctorRepository>();
            _repoMock.Setup(docRepo => docRepo.GetById(It.IsAny<long>())).Returns(new DoctorDto());
            var obj = _repoMock.Object;
            var mgr = new DoctorManager(obj);
            Assert.IsNotNull(mgr);

        }




        [TestMethod]


        public void GetDoctorById()
        {
            var _repoMock = new Mock<IDoctorRepository>();
            _repoMock.Setup(docRepo => docRepo.GetById(It.IsAny<long>())).Returns(new DoctorDto());
            var obj = _repoMock.Object;
            var res = obj.GetById(2);
            Assert.AreEqual(res.DoctorID, 0);
        }

        [TestMethod]


        public void GetDoctorByEmail()
        {
            var _repoMock = new Mock<IDoctorRepository>();
            _repoMock.Setup(docRepo => docRepo.GetByEmail(It.IsAny<string>())).Returns(new DoctorDto());
            var obj = _repoMock.Object;
            var res = obj.GetByEmail("shashwat16suyash@gmail.com");
            Assert.AreEqual(res.Email, (null));
        }


    }
}
