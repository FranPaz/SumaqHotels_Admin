var sumaqHotelsApp = angular.module('sumaqHotelsApp', ['ngRoute', 'ngResource', 'ui.router', 'ngCookies', 'ui.bootstrap', 'ngTable', 'googlechart',
  'ngSanitize', 'ngAnimate', 'ui.select', 'ct.ui.router.extras', 'angular-loading-bar', 'daypilot'])
    .config(function ($stateProvider, $urlRouterProvider, $httpProvider, $stickyStateProvider, cfpLoadingBarProvider) {

        cfpLoadingBarProvider.includeSpinner = true;
        cfpLoadingBarProvider.includeBar = true;
        //$httpProvider.interceptors.push('httpInterceptor');

        $urlRouterProvider.otherwise("/");

        $stateProvider //fpaz: defino los states que van a guiar el ruteo de las vistas parciales de la app       
        //#region Home
          .state('home', {
              url: "/",
              views: {
                  'content': {
                      templateUrl: '/Scripts/App/Dashboard/Partials/HomeAdmin.html',
                      controller: ''
                  }
              }
          })
			.state('booking', {
                url: "/Booking",
                views: {
                    'content': {
                        templateUrl: '/Scripts/App/Booking/Partials/demo.html',
                        controller: 'bookingCtrl'
                    }
                }
            })
        //#endregion  

        //#region Hoteles
          .state('hotel', {
              url: "/Hotel",
              views: {
                  'content': {
                      templateUrl: '/Scripts/App/Hoteles/Partials/hotelesMain.html',
                      controller: 'hotelesCtrl',
                      resolve: {
                          hotelesDataFactory: 'hotelesDataFactory',
                          infoHotel: function () {
                              return { value: [] };
                          },
						  tiposHotelesDataFactory: 'tiposHotelesDataFactory',
                          listadoTiposHoteles: function (tiposHotelesDataFactory) {
                              return tiposHotelesDataFactory.query();
                          },
                          categoriasDataFactory: 'categoriasDataFactory',
                          listadoCategorias: function (categoriasDataFactory) {
                              return categoriasDataFactory.query();
                          }
                      }
                  }
              }
          })
        //#endregion  

        //#region Tipos Habitacion
          .state('tipoHab', {
              url: "/TipoHabitaciones",
              views: {
                  'content': {
                      templateUrl: '/Scripts/App/TiposHabitacion/Partials/tiposHabMain.html',
                      controller: 'tiposHabCtrl',
                      resolve: {
                          tiposHabDataFactory: 'tiposHabDataFactory',                          
                          listadoTiposHab: function (tiposHabDataFactory) {
                              return tiposHabDataFactory.query();
                          },
                          tiposCamasDataFactory: 'tiposCamasDataFactory',
                          listadoTiposCamas: function (tiposCamasDataFactory) {
                              return tiposCamasDataFactory.query();
                          },
                          serviciosDataFactory: 'serviciosDataFactory',
                          listadoServicios: function (serviciosDataFactory) {
                              return serviciosDataFactory.query();
                          },

                      }
                  }
              }
          })          
        //#endregion  

        //#region Habitaciones
          .state('habitaciones', {
              url: "/Habitaciones",
              views: {
                  'content': {
                      templateUrl: '/Scripts/App/Habitaciones/Partials/habitacionesDetail.html',
                      controller: 'habitacionesCtrl',
                      resolve: {
                          habitacionesDataFactory: 'habitacionesDataFactory',
                          infoHabitacion: function () {
                              return { value: [] };
                          },
                          listadoHabitaciones: function (habitacionesDataFactory) {
                              return habitacionesDataFactory.query();
                          },
						  prmTipoHab: function () {
                              return { value: [] };
                          }
                      }
                  }
              }
          })
        //#endregion  

        //#region Pasajeros
          .state('pasajeros', {
              url: "/PasajerosList",
              views: {
                  'content': {
                      templateUrl: '/Scripts/App/Pasajeros/Partials/pasajerosMain.html',
                      controller: 'pasajerosCtrl',
                      resolve: {
                          //pasajerosDataFactory: 'pasajerosDataFactory',
                          //infoPasajero: function () {
                          //    return { value: [] };
                          //},
                          //listadoPasajeros: function (pasajerosDataFactory) {
                          //    return pasajerosDataFactory.query();
                          //}
                      }
                  }
              }
          })

         .state('pasajerosAdd', {
             url: "/PasajerosAdd",
             views: {
                 'content': {
                     templateUrl: '/Scripts/App/Pasajeros/Partials/pasajerosAdd.html',
                     controller: 'pasajerosCtrl',
                     resolve: {
                         //pasajerosDataFactory: 'pasajerosDataFactory',
                         //infoPasajero: function () {
                         //    return { value: [] };
                     }
                 }
             }
         })


//#endregion  
        
});

