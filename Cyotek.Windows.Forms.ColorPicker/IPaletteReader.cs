﻿namespace Cyotek.Windows.Forms
{
  // Cyotek Color Picker controls library
  // Copyright © 2013 Cyotek. All Rights Reserved.
  // http://cyotek.com/blog/tag/colorpicker

  // If you use this code in your applications, donations or attribution is welcome

  public interface IPaletteReader
  {
    #region Properties

    string FileName { get; set; }

    #endregion

    #region Members

    ColorCollection ReadPalette();

    #endregion
  }
}