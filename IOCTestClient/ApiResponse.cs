﻿using System.Collections.Generic;

namespace IOCTestClient
{
    internal class ApiResponse
    {
        private int _code;

        public ApiResponse(int code)
        {
            _code = code;
        }

        public Dictionary<string, object> Data { get; set; }
    }
}