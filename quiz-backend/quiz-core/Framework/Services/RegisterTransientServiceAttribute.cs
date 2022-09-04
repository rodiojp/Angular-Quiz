﻿using System;

namespace quiz_core.Framework.Services
{
    /// <summary>
    /// Mark a service for registration in the DI with a Transient lifetime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class RegisterTransientServiceAttribute : Attribute
    {
    }
}
