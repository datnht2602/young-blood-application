﻿using Clinic.Data.Models;
using Clinic.DTO.Models;

namespace Clinic.ApiGateway.Contracts
{
    public interface IClinicService
    {
        Task<IEnumerable<DoctorListViewModel>> GetDoctorsAsync(string filterCriteria = null);

        Task<DoctorDetailsViewModel> GetDoctorByIdAsync(string id);

        Task<BookingDetailsViewModel> CreateOrUpdateBooking(BookingDetailsViewModel model);

        Task<BookingDetailsViewModel> GetBookingByIdAsync(string orderId);

        Task<InvoiceDetailsViewModel> GetInvoiceByIdAsync(string orderId);

        Task<InvoiceDetailsViewModel> SubmitOrder(BookingDetailsViewModel order);
        Task<BookingViewModel> GetBookingDetail(string userId);
        Task<object> GetDiscountForCode(string code);
        Task<bool> BookingSuccess(string id);
    }
}
