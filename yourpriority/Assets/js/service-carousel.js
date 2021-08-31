// jQuery script for service carousel

$(document).on('ready', function () {
    "use strict";
    $(".service").owlCarousel({

        autoPlay: 6000, //Set AutoPlay to 3 seconds
        navigation: true, // Show next and prev buttons
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        items: 3,
        itemsDesktop: [1199, 3],
        itemsDesktopSmall: [979, 3],
        pagination: false

    });

});// jQuery script for service carousel

$(document).on('ready', function () {
    "use strict";
    $(".testimonial").owlCarousel({

        autoPlay: 5000, //Set AutoPlay to 3 seconds
        navigation: true, // Show next and prev buttons
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        items: 3,
        itemsDesktop: [1199, 3],
        itemsDesktopSmall: [979, 3],
        pagination: false

    });

});
$(document).on('ready', function () {
    "use strict";
    $(".logo-slider").owlCarousel({

        autoPlay: 4000, //Set AutoPlay to 3 seconds
        navigation: false, // Show next and prev buttons
        navigationText: false,
        itemsDesktop: [1199, 3],
        itemsDesktopSmall: [979, 3],
        pagination: false

    });

});
