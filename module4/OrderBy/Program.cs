﻿using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.OrderByQuery();
//var result = vm.OrderByMethod();
//var result = vm.OrderByDescendingQuery();
var result = vm.OrderByDescendingMethod();

// Display Results
vm.Display(result);