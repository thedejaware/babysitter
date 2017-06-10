/* Copyright: Babysitter @DigiSamaritan || digisamaritan@gmail.com*/
/*jslint browser: true*/
/*global $, jQuery, alert*/

/*--------------------------------------------------------------
TABLE OF CONTENTS:
----------------------------------------------------------------
# Document Ready
## Vars
## Page Pre Loading
## Babysitters Results - Grid List View
## Shopping Product Items - Grid List View
## Processing Steps -Signup
## Scroll To Top
## MixItUp Filtering
## Date Picker
## JRate Star Rating
## Select2 Dropdown Picker
## Revolution Slider
## Owl Carousel - Top Rated Blog Slider
## Owl Carousel - Blog Member Slider
## Owl Carousel - Like Slider
## Owl Carousel - Event Sponsors Slider
## Owl Carousel - Top Menu Slider
## Owl Carousel - Event Speakers Slider
## Owl Carousel - Widget Slider
## Owl Carousel - Thumbnail Shop Single Product
## Changing Click Event to Hover
## Magnificpop Lightbox Gallery
## Magnificpop Video Gallery
--------------------------------------------------------------*/

/* Document Ready */
jQuery(document).ready(function () {

    "use strict";

    /* Vars */
    var revapi,
        owl,
        wow,
        $products_item,
        $popup_gallery;

    // Page Pre Loading
    $(window).load(function () { // makes sure the whole site is loaded
        $('#status').fadeOut(); // will first fade out the loading animation
        $('#preloader').delay(350).fadeOut('slow'); // will fade out the white DIV that covers the website.
        $('body').delay(350).css({
            'overflow': 'visible'
        });
    });

    /* Babysitters Results : Grid List View  */
    $products_item = $('.products .item');
    $('#list').on("click", function (event) {
        event.preventDefault();
        $products_item.addClass('list-view');
        $(this).css("color", "#2dd1af");
        $('#grid').css("color", "#e6e6e6");
    });
    $('#grid').on("click", function (event) {
        event.preventDefault();
        $products_item.removeClass('list-view');
        $('#list').css("color", "#e6e6e6");
        $(this).css("color", "#2dd1af");
    });

    /* Shopping Product Items : Grid List View */
    $("#list2").on("click", function (event) {
        event.preventDefault();
        $products_item.addClass('list-view');
        $(this).css("color", "#2dd1af");
        $('#grid2').css("color", "#e6e6e6");
    });
    $("#grid2").on("click", function (event) {
        event.preventDefault();
        $products_item.removeClass('list-view');
        $(this).css("color", "#2dd1af");
        $('#list2').css("color", "#e6e6e6");
    });

    //Processing Steps : Step to step Process for Signup
    $('.next-step').on("click", function (event) {
        event.preventDefault();
        var currentEle = '#step-' + event.currentTarget.id,
            currentEle2 = '#label-' + event.currentTarget.id,
            currentEle3 = '#label-' + (parseInt(event.currentTarget.id, 10) + 1);
        $(currentEle).addClass('newul').html("<i class='fa fa-check'></i>").parent().addClass("newelpar");
        $(currentEle2).addClass('process-lab').find('span').html("<i class='fa fa-check'></i>");
        $(currentEle3).addClass('process-lab2');
        $('#payment-ul li:eq(' + event.currentTarget.id + ') a').tab('show');
    });

    // Scroll To Top - Stops at 500px from top
    $('.next-step').on("click", function () {
        $('body,html').animate({
            scrollTop: 500
        }, 1000);
        return false;
    });

    // Scroll To Top
    $('.back-to-top').on("click", function () {
        $('body,html').animate({
            scrollTop: 0
        }, 800);
        return false;
    });

    /* MixItUp jQuery plugin -- for animated filtering and sorting */
    $('#ContainerMix').mixItUp();

    //Date Picker -- Calendar
    $("#datepicker-1").datepicker();
    $("#datepicker-2").datepicker();

    /* JRATE Star Rating -- SVG based Rating jQuery plugin -- for docs rafy-fa plugin -- http://jacob87.github.io/raty-fa/ */
    $('.startRate').raty({
        score: 4
    });

    //Select2 Dropdown Picker -- jQuery replacement for select boxes
    $(".select-picker").select2();
    $(".select-picker-default").select2({
        minimumResultsForSearch: Infinity
    });

    //wow scrolling animation
    wow = new WOW();
    wow.init();

    //Revolution Slider for Home Page -- Hero Header
    revapi = $("#rev_slider").revolution({
        sliderType: "standard",
        sliderLayout: "fullwidth",
        delay: 3000,
        navigation: {
            arrows: {
                enable: true
            }
        },
        gridwidth: 1230,
        gridheight: 720
    });

    // Owl Carousel - Top Rated Blog Slider
    $('.owl-carousel').owlCarousel({
        loop: true,
        dots: true,
        nav: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            768: {
                items: 3
            },
            992: {
                items: 3
            },
            1000: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    });

    // Owl Carousel - Blog Member Slider
    $('.members-slider').owlCarousel({
        loop: true,
        dots: true,
        nav: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            992: {
                items: 3
            },
            1000: {
                items: 4
            },
            1200: {
                items: 5
            }
        }
    });

    // Owl Carousel - Like Slider
    $('.like-slider').owlCarousel({
        margin: 10,
        dots: true,
        nav: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            992: {
                items: 2
            },
            1000: {
                items: 2
            },
            1200: {
                items: 3
            }
        }
    });

    // Owl Carousel - Event Sponsors Slider
    $('.event-sponsors').owlCarousel({
        dots: true,
        nav: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            992: {
                items: 3
            },
            1000: {
                items: 4
            }
        }
    });

    // Owl Carousel - Top Menu Slider
    $("#owl-slider-top-menu").owlCarousel({
        center: true,
        items: 2,
        loop: true,
        nav: true,
        navText: ["<img src='images/ra.png'>", "<img src='images/la.png'>"],
        dots: false,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            992: {
                items: 2
            },
            1000: {
                items: 3
            },
            1200: {
                items: 3
            }
        }

    });

    // Owl Carousel - Event Speakers Slider
    $(".event-speakers").owlCarousel({
        items: 2,
        loop: true,
        nav: true,
        navText: [
            "<i class=' left-arrow'></i>",
            "<i class=' right-arrow'></i>"
        ],
        dots: false,

        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            992: {
                items: 2
            },
            1000: {
                items: 2
            },
            1200: {
                items: 2
            }
        }

    });

    // Owl Carousel - Widget Slider
    $('.widget-slider').owlCarousel({
        loop: true,
        dots: true,
        nav: true,
        navText: ["<img src='images/w-la.png'>", "<img src='images/w-ra.png'>"],
        items: 1
    });

    // Owl Carousel - Thumbnail Shop Single Product
    owl = $('.thumb-carousel');
    owl.owlCarousel({
        loop: true,
        center: true,
        items: 1,
        autoplay: false,
        thumbs: true,
        thumbImage: true,
        thumbContainerClass: 'owl-thumbs',
        thumbItemClass: 'owl-thumb-item',
        thumbsPrerendered: true
    });

    /* Changing Click Event to Hover - Thumbnail Slider on hover image change */
    $('.thumb-carousel .owl-thumb-item').hover(function () {
        $(this).click();
    });

    // Magnificpop Lightbox Gallery - open image gallery in popoup window
    $popup_gallery = $('.popup-gallery');
    if ($popup_gallery.length) {
        $popup_gallery.magnificPopup({
            delegate: 'a',
            type: 'image',
            tLoading: 'Loading image #%curr%...',
            mainClass: 'mfp-img-mobile',
            gallery: {
                enabled: true,
                navigateByImgClick: true,
                preload: [0, 1]
            },
            image: {
                tError: '<a href="%url%">The image #%curr%</a> could not be loaded.'
            },
            zoom: {
                enabled: true,
                duration: 300,
                opener: function (element) {
                    return element.find('img');
                }
            }
        });
    }

    // Magnificpop Video Gallery - plays in popup window
    $('.videopopUp').magnificPopup({
        type: 'iframe',
        iframe: {
            markup: '<div class="mfp-iframe-scaler">' +
                '<div class="mfp-close"></div>' +
                '<iframe class="mfp-iframe" frameborder="0" allowfullscreen></iframe>' +
                '</div>', // HTML markup of popup, `mfp-close` will be replaced by the close button
            patterns: {
                youtube: {
                    index: 'youtube.com/', // String that detects type of video (in this case YouTube). Simply via url.indexOf(index).
                    id: 'v=', // String that splits URL in a two parts, second part should be %id%
                    src: 'https://www.youtube.com/embed/%id%' // URL that will be set as a source for iframe.
                },
                vimeo: {
                    index: 'vimeo.com/',
                    id: '/',
                    src: 'https://player.vimeo.com/video/%id%'
                }
            },
            srcAction: 'iframe_src' // Templating object key. First part defines CSS selector, second attribute. "iframe_src" means: find "iframe" and set attribute "src".
        }
    });

});
