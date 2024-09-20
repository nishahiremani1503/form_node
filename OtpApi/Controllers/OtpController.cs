using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class OtpController : ControllerBase
{
    [HttpPost("send")]
    public IActionResult SendOtp([FromBody] OtpRequest request)
    {
        var otp = new Random().Next(100000, 999999).ToString();
        return Ok(new { Message = "OTP sent", Otp = otp });
    }

    [HttpPost("verify")]
    public IActionResult VerifyOtp([FromBody] OtpVerificationRequest request)
    {
        return Ok(new { Message = "OTP verified" });
    }
}

public class OtpRequest
{
    public string PhoneNumber { get; set; }
}

public class OtpVerificationRequest
{
    public string PhoneNumber { get; set; }
    public string Otp { get; set; }
}
