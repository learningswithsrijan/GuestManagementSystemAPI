using DataAccessLayer;
using DataAccessLayer.Services;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GMS.Tests
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void AccessGuestDetails()
        {
            try
            {
                var _context = new GuestManagementSystemContext();
                var _guestdetailsvc = new GuestDetailsService(_context);

                GuestDetail guestDetail = new GuestDetail();
                guestDetail.TravelingInGroup = false;
                guestDetail.GroupId = 10;
                guestDetail.FirstName = "Srijan";
                guestDetail.LastName = "Kumar";
                guestDetail.AddressLine1 = "Ashok Nagar, Road No. 1";
                guestDetail.AddressLine2 = "Kankarbagh";
                guestDetail.Town = "Patna Sadar";
                guestDetail.District = "Patna";
                guestDetail.State = "Bihar";
                guestDetail.Pin = 800020;
                guestDetail.EmailIdprimary = "srijankumarjaiswal@hotmail.com";
                guestDetail.MobileNumberPrimary = 9986750079;

                _guestdetailsvc.Insert(guestDetail);
            }
            catch (Exception ex)
            {

            }

        }
    }
}