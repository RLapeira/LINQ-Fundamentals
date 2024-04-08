using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.AllQuery();
//var result = vm.AllMethod();
//var result = vm.AllSalesQuery();
//var result = vm.AllSalesMethod();
//var result = vm.AnyQuery();
//var result = vm.AnyQuery();
//var result = vm.ContainsQuery();
var result = vm.ContainsMethod();

// Display Results
vm.Display(result);