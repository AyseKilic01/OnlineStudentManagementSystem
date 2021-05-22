/**=========================================================
 * Module: demo-pagination.js
 * Provides a simple demo for pagination
 =========================================================*/

 App.controller('MailboxController', function($scope) {

  $scope.mail = {
    cc: false,
    bcc: false
  };

  // Mailbox editr initial content
  $scope.content = "<p>Type something..</p>";


});