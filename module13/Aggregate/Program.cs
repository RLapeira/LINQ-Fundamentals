﻿using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.CountQuery();
//var result = vm.CountMethod();
//var result = vm.CountFilteredQuery();
//var result = vm.CountFilteredMethod();
//var result = vm.MinQuery();
//var result = vm.MinMethod();
//var result = vm.MaxQuery();
var result = vm.MaxMethod();

// Display Results
vm.Display(result);