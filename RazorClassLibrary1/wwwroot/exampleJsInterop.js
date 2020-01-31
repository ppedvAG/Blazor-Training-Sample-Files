// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.exampleJsFunctions = {
  showPrompt: function (message) {
    return prompt(message, 'Type anything here');
  }
};
function showPrompt2(message) {
    prompt(message, "tippen");
}
//das geht nun auch (überraschung)
