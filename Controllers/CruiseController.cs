using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vacay.Services;

namespace Vacay.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CruiseController : ControllerBase
  {
    private readonly CruiseService _cs;

    public CruiseController(CruiseService cs)
    {
      _cs = cs;
    }

  }
}