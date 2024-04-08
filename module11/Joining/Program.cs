using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.InnerJoinQuery();
//var result = vm.InnerJoinMethod();
//var result = vm.InnerJoinTwoFieldsQuery();
var result = vm.InnerJoinTwoFieldsMethod();

// Display Results
vm.Display(result);