function callMethod() {
    DotNet.invokeMethodAsync("BlazorServerAppDemo", "GetValueFromMethod").then(result => {
        alert(result);
            });
}