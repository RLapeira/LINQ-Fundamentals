﻿using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.UnionQuery();
var result = vm.UnionMethod();

// Display Results
vm.Display(result);