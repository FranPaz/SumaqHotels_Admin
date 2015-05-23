sumaqHotelsApp.controller('hotelesCtrl', function ($scope, $stateParams, $state, $filter, ngTableParams, hotelesDataFactory)
//, listadoHoteles, infoHoteles
{
     $scope.oneAtATime = true;
     $scope.Hotel = [];
     $scope.Hotel.Stars = 1;
  $scope.groups = [
    {
      title: 'Dynamic Group Header - 1',
      content: 'Dynamic Group Body - 1'
    },
    {
      title: 'Dynamic Group Header - 2',
      content: 'Dynamic Group Body - 2'
    }
  ];

  $scope.items = ['Item 1', 'Item 2', 'Item 3'];

  $scope.addItem = function() {
    var newItemNo = $scope.items.length + 1;
    $scope.items.push('Item ' + newItemNo);
  };

  $scope.status = {
    isFirstOpen: true,
    isFirstDisabled: false
  };

    //manejo de Estrellas de Hotel
  $scope.hoveringOver = function (value) {
      $scope.overStar = value;
  };

    //Manejo de Carrousel

  $scope.myInterval = 5000;
  var slides = $scope.slides = [];
  $scope.addSlide = function (i) {
      var newWidth = 6 + i;
      slides.push({
          //image: 'http://placekitten.com/' + newWidth + '/300',
          image: 'http://q-ec.bstatic.com/images/hotel/840x460/420/4204142' + newWidth + '.jpg',
          text: ['Lobby', 'Reception', 'Main', 'Confort'][slides.length % 4] + ' ' +
            ['Place', 'Bar', 'Rooms', 'Beds'][slides.length % 4]
      });
  };
  for (var i = 0; i < 4; i++) {
      $scope.addSlide(i);
  }




});