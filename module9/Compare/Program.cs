﻿using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.SequenceEqualIntegersQuery();
//var result = vm.SequenceEqualIntegersMethod();
//var result = vm.SequenceEqualObjectsQuery();
//var result = vm.SequenceEqualObjectsMethod();
//var result = vm.SequenceEqualUsingComparerQuery();
//var result = vm.SequenceEqualUsingComparerMethod();
//var result = vm.ExceptIntegersQuery();
//var result = vm.ExceptIntegersMethod();
//var result = vm.ExceptProductSalesQuery();
//var result = vm.ExceptProductSalesMethod();
//var result = vm.ExceptUsingComparerQuery();
//var result = vm.ExceptUsingComparerMethod();
//var result = vm.ExceptByQuery();
//var result = vm.ExceptByMethod();
//var result = vm.ExceptByProductSalesQuery();
var result = vm.ExceptByProductSalesMethod();

// Display Results
vm.Display(result);