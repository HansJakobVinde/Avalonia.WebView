﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ObjCRuntime;

[StructLayout(LayoutKind.Explicit)]
internal struct ObjectWrapper
{
    [FieldOffset(0)]
    private object obj;

    [FieldOffset(0)]
    private IntPtr handle;

    internal static IntPtr Convert(object obj)
    {
        if (obj == null)
        {
            return IntPtr.Zero;
        }
        ObjectWrapper objectWrapper = default(ObjectWrapper);
        objectWrapper.obj = obj;
        return objectWrapper.handle;
    }

    internal static object Convert(IntPtr ptr)
    {
        ObjectWrapper objectWrapper = default(ObjectWrapper);
        objectWrapper.handle = ptr;
        return objectWrapper.obj;
    }
}