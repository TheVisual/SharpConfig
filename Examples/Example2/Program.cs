﻿// Copyright (c) 2022 Michael Tsai, MIT License.
// https://github.com/huanlin/SharpConfig

using Example2.Config;

var config = AppConfig.GetInstance();
config.Load();

Console.WriteLine($"AutoUpdate: {config.General.AutoUpdate}");
Console.WriteLine($"PrintTextFontSize: {config.Printing.PrintTextFontSize}");
