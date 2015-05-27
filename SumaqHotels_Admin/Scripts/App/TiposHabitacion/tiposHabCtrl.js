sumaqHotelsApp.controller('tiposHabCtrl', function ($scope, $stateParams, $state, $filter, ngTableParams, tiposHabDataFactory, listadoTiposHab, listadoTiposCamas, listadoServicios) {
    
    //#region Inicializacion de variables de Scope
    $scope.listTiposHab = listadoTiposHab; // var donde voy a guardar todos los Tipos de Habitacion ya sea cuando se cargue la pagina o cuando agregue una nueva
    $scope.infoTipoHab = {}; // var que voy a usar para el abm y para tener informacion sobre un tipo de habitacion en particular
    $scope.tipoHabSelec = {}; // var que va a tener la cama seleccionada
    $scope.tipoHabSelec.selected = {};

    $scope.editValue = false; // variable que voya usar para activar y desactivar los modos de edicion 
    $scope.addValue = true; //para activar el alta de Campos
    $scope.showCamasCollapse = false; //var para hacer el collapse de la seccion de Camas Adicionales

    $scope.listHabitaciones = []; // array de habitaciones de un tipo determinado. Se llena al elegir el tipo de habitacion

    $scope.tiposCamas = listadoTiposCamas; // listado con el tipo de camas que se pueden agregar
    $scope.tipoCamaSelecciononada = {}; // var que va a tener la cama seleccionada
    $scope.tipoCamaSelecciononada.selected = {};

    $scope.tipoCamaAgregada = {}; //objeto que va a tener el tipo de cama agregada, la cantidad y el precio por unidad
    $scope.listCamasAdicionales = []; // array de tipos de camas agregadas para armar el tarifario de camas adicionales

    $scope.servicios = listadoServicios; // lista de servicios disponibles
    $scope.servicioSeleccionado = [];
    $scope.servicioSeleccionado.selected = {};
    

    //#endregion

    ////#region Alta de Campos Programaticos
    ////funcion para agregar un nuevo Campos Programaticos y mostrarlo en la tabla
    //$scope.addCampoProg = function () {
    //    $scope.camposProg = camposProgDataFactory.query();
    //};

    //$scope.campoProgAdd = function (campoProg) {
    //    campoProg.TipoCampoProgramaticoId = $scope.tipo.selected.Id;

    //    if ($scope.tipo.selected.Id != null) {
    //        campoProg.TipoCampoJurisdiccionalId = $scope.tipoJuris.selected.Id;
    //    }
    //    camposProgDataFactory.save(campoProg).$promise.then(
    //        function () {
    //            $scope.addCampoProg();
    //            $scope.infoCampoProg = null;
    //            alert('Nuevo Campo Programatico Guardado');
    //        },
    //        function (response) {
    //            $scope.errors = response.data;
    //            alert('Error al guardar el Campo Programatico');
    //        });
    //};
    ////#endregion

    //// devuelve los datos detallados del campo programatico para la seccion Administracion       
    //$scope.detalle = function (campoProg) {
    //    $scope.addValue = false;
    //    $scope.infoCampoProg = camposProgDataFactory.get({ id: campoProg.Id });
    //    if (campoProg.TipoCampoProgramatico.Descripcion == 'Campo Jurisdiccional') {
    //        $scope.showTipoCampoJuris = true;
    //    } else {
    //        $scope.showTipoCampoJuris = false;
    //    }
    //    $scope.adminCamposCollapse = false;
    //};

    //// limpia los campos de admin. y los deja listo para agregar un nuevo registro o limpiar los datos q actualmente estoy escribiendo
    //$scope.clear = function () {
    //    $scope.infoTipoHab = {};

    //    $scope.tipo = {};
    //    $scope.tipo.selected = {};

    //    $scope.tipoJuris = {};
    //    $scope.tipoJuris.selected = {};
    //    $scope.showTipoCampoJuris = false;

    //    if (!$scope.addValue) {
    //        $scope.editValue = false;
    //        $scope.addValue = true;
    //    }
    //};

});