﻿using System;
using System.Collections.Generic;
using System.Text;
using AntDesign.TableModels;
using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    internal interface IColumn
    {
        public ITable Table { get; }

        public int ColIndex { get; set; }

        public string Fixed { get; set; }

        public string Title { get; set; }

        public string Width { get; set; }

        public int ColSpan { get; set; }

        public int RowSpan { get; set; }

        public int HeaderColSpan { get; set; }

        public bool Hidden { get; set; }

        void Load();
    }
}
