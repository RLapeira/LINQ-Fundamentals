using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.GroupByQuery();
//var result = vm.GroupByMethod();
//var result = vm.GroupByUsingKeyQuery();
//var result = vm.GroupByUsingKeyMethod();
//var result = vm.GroupByWhereQuery();
var result = vm.GroupByWhereMethod();

// Display Results
vm.Display(result);