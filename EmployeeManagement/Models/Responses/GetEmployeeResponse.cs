﻿namespace EmployeeManagement.Models.Responses;

public class GetEmployeeResponse : BaseResponse
{
    public Employee? Employee { get; set; }
}
