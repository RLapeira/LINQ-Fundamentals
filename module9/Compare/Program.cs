﻿using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.SequenceEqualIntegersQuery();
var result = vm.SequenceEqualIntegersMethod();

// Display Results
vm.Display(result);