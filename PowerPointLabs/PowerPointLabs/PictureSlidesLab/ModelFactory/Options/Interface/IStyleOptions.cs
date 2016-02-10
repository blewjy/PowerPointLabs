﻿using System.Collections.Generic;
using PowerPointLabs.PictureSlidesLab.Model;

namespace PowerPointLabs.PictureSlidesLab.ModelFactory.Options.Interface
{
    interface IStyleOptions
    {
        List<StyleOption> GetOptionsForVariation();

        StyleOption GetDefaultOptionForPreview();
    }
}
