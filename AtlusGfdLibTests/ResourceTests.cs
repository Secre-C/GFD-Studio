﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtlusGfdLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Diagnostics;
using AtlusGfdLib.IO;

namespace AtlusGfdLib.Tests
{
    [TestClass()]
    public class ResourceTests
    {
        [TestMethod()]
        public void LoadFromFileTest()
        {
            var res = Resource.Load( @"D:\Modding\Persona 5 EU\Main game\Extracted\data\model\character\0001\c0001_051_00.GMD" );
        }

        [TestMethod()]
        public void LoadFromStreamTest()
        {
            using ( var fileStream = File.OpenRead( @"D:\Modding\Persona 5 EU\Main game\Extracted\data\model\character\0001\c0001_001_00.GMD" ) )
                Resource.Load( fileStream );
        }

        [TestMethod()]
        public void SaveToFileTest()
        {
            var model = Resource.Load<Model>( @"D:\Modding\Persona 5 EU\Main game\Extracted\data\model\character\0001\c0001_051_00.GMD" );
            Resource.Save( model, @"D:\Modding\Persona 5 EU\Main game\Extracted\data\model\character\0001\c0001_051_00_new.GMD" );
        }
    }
}