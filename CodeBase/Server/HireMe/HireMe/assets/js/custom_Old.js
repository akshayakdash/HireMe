/*
 *
 *		CUSTOM.JS
 *
 */

// WAVES EFFECT //
!function(t){"use strict";function e(t){return null!==t&&t===t.window}function n(t){return e(t)?t:9===t.nodeType&&t.defaultView}function a(t){var e,a,i={top:0,left:0},o=t&&t.ownerDocument;return e=o.documentElement,void 0!==t.getBoundingClientRect&&(i=t.getBoundingClientRect()),a=n(o),{top:i.top+a.pageYOffset-e.clientTop,left:i.left+a.pageXOffset-e.clientLeft}}function i(t){var e="";for(var n in t)t.hasOwnProperty(n)&&(e+=n+":"+t[n]+";");return e}function o(t){if(!1===d.allowEvent(t))return null;for(var e=null,n=t.target||t.srcElement;null!==n.parentElement;){if(!(n instanceof SVGElement||-1===n.className.indexOf("waves"))){e=n;break}if(n.classList.contains("waves")){e=n;break}n=n.parentElement}return e}function r(e){var n=o(e);null!==n&&(c.show(e,n),"ontouchstart"in t&&(n.addEventListener("touchend",c.hide,!1),n.addEventListener("touchcancel",c.hide,!1)),n.addEventListener("mouseup",c.hide,!1),n.addEventListener("mouseleave",c.hide,!1))}var s=s||{},u=document.querySelectorAll.bind(document),c={duration:750,show:function(t,e){if(2===t.waves)return!1;var n=e||this,o=document.createElement("div");o.className="waves-ripple",n.appendChild(o);var r=a(n),s=t.pageY-r.top,u=t.pageX-r.left,d="scale("+n.clientWidth/100*15+")";"touches"in t&&(s=t.touches[0].pageY-r.top,u=t.touches[0].pageX-r.left),o.setAttribute("data-hold",Date.now()),o.setAttribute("data-scale",d),o.setAttribute("data-x",u),o.setAttribute("data-y",s);var l={top:s+"px",left:u+"px"};o.className=o.className+" waves-notransition",o.setAttribute("style",i(l)),o.className=o.className.replace("waves-notransition",""),l["-webkit-transform"]=d,l["-moz-transform"]=d,l["-ms-transform"]=d,l["-o-transform"]=d,l.transform=d,l.opacity="1",l["-webkit-transition-duration"]=c.duration+"ms",l["-moz-transition-duration"]=c.duration+"ms",l["-o-transition-duration"]=c.duration+"ms",l["transition-duration"]=c.duration+"ms",l["-webkit-transition-timing-function"]="cubic-bezier(0.250, 0.460, 0.450, 0.940)",l["-moz-transition-timing-function"]="cubic-bezier(0.250, 0.460, 0.450, 0.940)",l["-o-transition-timing-function"]="cubic-bezier(0.250, 0.460, 0.450, 0.940)",l["transition-timing-function"]="cubic-bezier(0.250, 0.460, 0.450, 0.940)",o.setAttribute("style",i(l))},hide:function(t){d.touchup(t);var e=this,n=(e.clientWidth,null),a=e.getElementsByClassName("waves-ripple");if(!(a.length>0))return!1;var o=(n=a[a.length-1]).getAttribute("data-x"),r=n.getAttribute("data-y"),s=n.getAttribute("data-scale"),u=350-(Date.now()-Number(n.getAttribute("data-hold")));u<0&&(u=0),setTimeout(function(){var t={top:r+"px",left:o+"px",opacity:"0","-webkit-transition-duration":c.duration+"ms","-moz-transition-duration":c.duration+"ms","-o-transition-duration":c.duration+"ms","transition-duration":c.duration+"ms","-webkit-transform":s,"-moz-transform":s,"-ms-transform":s,"-o-transform":s,transform:s};n.setAttribute("style",i(t)),setTimeout(function(){try{e.removeChild(n)}catch(t){return!1}},c.duration)},u)},wrapInput:function(t){for(var e=0;e<t.length;e++){var n=t[e];if("input"===n.tagName.toLowerCase()){var a=n.parentNode;if("i"===a.tagName.toLowerCase()&&-1!==a.className.indexOf("waves"))continue;var i=document.createElement("i");i.className=n.className+" waves-input-wrapper";var o=n.getAttribute("style");o||(o=""),i.setAttribute("style",o),n.className="waves-waves-input",n.removeAttribute("style"),a.replaceChild(i,n),i.appendChild(n)}}}},d={touches:0,allowEvent:function(t){var e=!0;return"touchstart"===t.type?d.touches+=1:"touchend"===t.type||"touchcancel"===t.type?setTimeout(function(){d.touches>0&&(d.touches-=1)},500):"mousedown"===t.type&&d.touches>0&&(e=!1),e},touchup:function(t){d.allowEvent(t)}};s.displayEffect=function(e){"duration"in(e=e||{})&&(c.duration=e.duration),c.wrapInput(u(".waves")),"ontouchstart"in t&&document.body.addEventListener("touchstart",r,!1),document.body.addEventListener("mousedown",r,!1)},s.attach=function(e){"input"===e.tagName.toLowerCase()&&(c.wrapInput([e]),e=e.parentElement),"ontouchstart"in t&&e.addEventListener("touchstart",r,!1),e.addEventListener("mousedown",r,!1)},t.Waves=s,document.addEventListener("DOMContentLoaded",function(){s.displayEffect()},!1)}(window);

(function($){

    "use strict";

    // DETECT TOUCH DEVICE //
    function is_touch_device() {
        return !!('ontouchstart' in window) || ( !! ('onmsgesturechange' in window) && !! window.navigator.maxTouchPoints);
    }


    // SHOW/HIDE MOBILE MENU //
    function show_hide_mobile_menu() {

        $(".mobile-menu-button").on("click", function(e) {

            e.preventDefault();
            e.stopPropagation();

            $("#mobile-menu").toggleClass("open");
            $('body').toggleClass("body-overlay");

        });

        $("body").on("click", function() {
            if ($("#mobile-menu").hasClass("open")) {
                $("#mobile-menu").removeClass("open");
                $('body').removeClass("body-overlay");
            }
        });

    }



    // MOBILE MENU //
    function mobile_menu() {

        if ($(window).width() < 1200) {

            if ($("#menu").length > 0) {

                if ($("#mobile-menu").length < 1) {

                    $("#menu").clone().attr({
                        id: "mobile-menu",
                        class: ""
                    }).insertAfter("#header");

                    $("#mobile-menu > li > a").addClass("waves");

                    $("#mobile-menu li").each(function() {

                        if ($(this).hasClass('dropdown') || $(this).hasClass('megamenu')) {
                            $(this).append('<span class="arrow"></span>');
                        }

                    });

                    $("#mobile-menu .megamenu .arrow").on("click", function(e) {

                        e.preventDefault();
                        e.stopPropagation();

                        $(this).toggleClass("open").prev("div").slideToggle(300);

                    });

                    $("#mobile-menu .dropdown .arrow").on("click", function(e) {

                        e.preventDefault();
                        e.stopPropagation();

                        $(this).toggleClass("open").prev("ul").slideToggle(300);

                    });

                    $("#mobile-menu .widget-search").on("click", function(e) {

                        e.preventDefault();
                        e.stopPropagation();

                    });

                    $("#mobile-menu").prepend("<li class='logo'><img src='../assets/images/logo.png' alt=''></li>");

                }

            }

        } else {

            $("#mobile-menu").removeClass("open");
            $('body').removeClass("body-overlay");

        }

    }


    // SECONDARY MENU //
    function secondary_menu() {

        $(".menu li.secondary-menu-btn > a").on("click", function(e) {
            e.preventDefault();
            e.stopPropagation();
            $("body").toggleClass("secondary-menu-open")
        });

        $("body").on("click", function() {
            $("body").removeClass("secondary-menu-open")
        });

    }


    // MENU SLIDE //
    function menu_slide() {

        $(".menu-slide-container").prepend('<a class="close-menu" href="#">&times</a>');

        $(".menu-button").on("click", function(e) {

            e.preventDefault();
            $(".menu-slide-container").toggleClass("menu-open");
            $("#header, #header-sticky").toggleClass("header-hidden");

        });

        $(".close-menu").on("click", function(e) {

            e.preventDefault();
            $(".menu-slide-container").removeClass("menu-open");
            $("#header, #header-sticky").removeClass("header-hidden");

        });

        $(".menu-slide li").each(function() {

            if ($(this).hasClass('dropdown') || $(this).hasClass('megamenu')) {
                $(this).append('<span class="arrow"></span>');
            }

        });

        $(".menu-slide li.dropdown > span").on("click", function(e) {

            e.preventDefault();
            $(this).toggleClass("open").prev("ul").slideToggle(300);

        });

        $(".menu-slide li.megamenu > span").on("click", function(e) {

            e.preventDefault();
            $(this).toggleClass("open").prev("div").slideToggle(300);

        });

    }


    // STICKY //
    function sticky() {

        var sticky_point =  $("#header").innerHeight() + 100,
            slidedown_time = 300,
            slideup_time = 100;

        if ($('#page-header').next().is('#header')) {

            sticky_point = $('#page-header').innerHeight() + 1;
            slidedown_time = 0;
            slideup_time = 0;
        }

        if ($('.rev_slider_wrapper').next().is('#header')) {

            sticky_point = $('.rev_slider_wrapper').outerHeight(true) + 1;
            slidedown_time = 0;
            slideup_time = 0;
        }

        $("#header").clone().attr({
            id: "header-sticky",
            class: ""
        }).insertAfter("header");

        $("#header-sticky #logo img").attr("src", "../assets/images/logo.png");

        $(window).scroll(function(){

            if ($(window).scrollTop() > sticky_point) {
                $("#header-sticky").slideDown(slidedown_time).addClass("header-sticky");
                $("#header .menu ul, #header .menu .megamenu-container").css({"visibility": "hidden"});
            } else {
                $("#header-sticky").slideUp(slideup_time).removeClass("header-sticky");
                $("#header .menu ul, #header .menu .megamenu-container").css({"visibility": "visible"});
            }

            if ($(window).scrollTop() > sticky_point + $("#header").innerHeight()) {
                $("#header-sticky").addClass("activated")
            } else {
                $("#header-sticky").removeClass("activated")
            }

        });

    }


    // SEARCH //
    function header_search() {

        var inputWidth = '300px',
            inputWidthReturn = '34px';

        $('header #search-form #s, #header-top #search-form #s').on('focus', function () {
            $(this).val(function () {
                $(this).addClass('open').attr('placeholder', 'Search...');
            }),
                $(this).animate({
                    width: inputWidth
                }, "fast");
        });
        $('header #search-form #s, #header-top #search-form #s').on('blur', function () {
            $(this).removeClass('open').animate({
                width: inputWidthReturn
            }, "fast");
            $(this).attr('placeholder', '').val('');
        });

        if ($(window).width() < 1199) {
            $('header #search-form #s, #header-top #search-form #s').attr('placeholder', 'Search...');
            $('header #search-form #s, #header-top #search-form #s').on('blur', function() {
                $(this).attr('placeholder', 'Search...');
            })
        }

    }


    // PROGRESS BARS //
    function progress_bars() {

        $(".progress .progress-bar:in-viewport").each(function() {

            if (!$(this).hasClass("animated")) {
                $(this).addClass("animated");
                $(this).animate({
                    width: $(this).attr("data-width") + "%"
                }, 2000);
            }

        });

    }


    // CHARTS //
    function pie_chart() {

        if (typeof $.fn.easyPieChart !== 'undefined') {

            $(".pie-chart:in-viewport").each(function() {

                $(this).easyPieChart({
                    animate: 1500,
                    lineCap: "square",
                    lineWidth: $(this).attr("data-line-width"),
                    size: $(this).attr("data-size"),
                    barColor: function(percent) {
                        var ctx = this.renderer.getCtx();
                        var canvas = this.renderer.getCanvas();
                        var gradient = ctx.createLinearGradient(-50,-50,50,0);
                        gradient.addColorStop(0, '#fe005a');
                        gradient.addColorStop(1, '#310068');
                        return gradient;
                    },
                    trackColor: $(this).attr("data-track-color"),
                    scaleColor: "transparent",
                    onStep: function(from, to, percent) {
                        $(this.el).find(".pie-chart-percent .value").text(Math.round(percent));
                    }
                });

            });

        }

    }

    // COUNTER //
    function counter() {

        if (typeof $.fn.jQuerySimpleCounter !== 'undefined') {

            $(".counter .counter-value:in-viewport").each(function() {

                if (!$(this).hasClass("animated")) {
                    $(this).addClass("animated");
                    $(this).jQuerySimpleCounter({
                        start: 0,
                        end: $(this).attr("data-value"),
                        duration: 2000
                    });
                }

            });

        }
    }


    // ODOMETER //
    function odometer() {

        if (typeof Odometer !== 'undefined') {

            $(".odometer:in-viewport").each(function(index) {

                var new_id = 'odometer-' + index;

                this.id = new_id;

                var value = $(this).attr("data-value");

                if (!$(this).hasClass("animated")) {

                    $(this).addClass("animated");

                    setTimeout(function() {
                        document.getElementById(new_id).innerHTML = value;
                    });

                }

            });

        }

    }


    function statistics() {

        if (typeof Chart !== 'undefined') {

            $(".statistics-container .animate-chart:in-viewport").each(function() {

                if(!$(this).hasClass("animated")) {

                    $(this).addClass("animated");

                    var options = {
                        responsive: true,
                        legend: {
                            display: true,
                            labels: {
                                boxWidth: 12,
                                fontColor: "#252525",
                                fontFamily: "Source Sans Pro",
                                fontSize: 12,
                                padding: 20
                            }
                        },
                        tooltips: {
                            enabled: false
                        },
                        scales: {
                            xAxes: [{
                                display: true,
                                gridLines: {
                                    color: "rgba(0, 0, 0, 0)",
                                    zeroLineColor:"rgba(0, 0, 0, 0)"
                                },
                                ticks: {
                                    fontColor: "#252525",
                                    fontSize: 12,
                                    fontFamily: "Source Sans Pro",
                                    maxRotation: 0
                                }
                            }],
                            yAxes: [{
                                display: true,
                                ticks: {
                                    stepSize: 50,
                                    suggestedMin: 0,
                                    suggestedMax: 200,
                                }
                            }]
                        }
                    }

                    // LINE CHART //
                    if ($("#line-chart").length > 0) {

                        var line_ctx = document.getElementById('line-chart').getContext('2d');

                        var gradient1 = line_ctx.createLinearGradient(0,0,800,0);
                        gradient1.addColorStop(0, '#87ffd0');
                        gradient1.addColorStop(1, '#31d1ff');

                        var gradient2 = line_ctx.createLinearGradient(0,0,800,0);
                        gradient2.addColorStop(0, '#fe2f87');
                        gradient2.addColorStop(1, '#c731ff');

                        var gradient3 = line_ctx.createLinearGradient(0,0,800,0);
                        gradient3.addColorStop(0, '#2fd9fe');
                        gradient3.addColorStop(1, '#4887fa');

                        var data1 = {
                            labels : ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul"],
                            datasets : [
                                {
                                    fill: "true",
                                    label: "TAXES",
                                    backgroundColor: "transparent",
                                    borderWidth: 3,
                                    borderColor: gradient3,
                                    pointBorderColor: gradient3,
                                    pointBackgroundColor: gradient3,
                                    pointHoverBackgroundColor: gradient3,
                                    pointHoverBorderColor: gradient3,
                                    pointBorderWidth: 2,
                                    pointHoverBorderWidth: 1,
                                    tension: 0.3,
                                    stacked: false,
                                    data : [95, 140, 110, 150, 140, 130, 175]
                                },
                                {
                                    fill: "true",
                                    label: "REVENUE",
                                    backgroundColor: "transparent",
                                    borderWidth: 3,
                                    borderColor: gradient2,
                                    pointBorderColor: gradient2,
                                    pointBackgroundColor: gradient2,
                                    pointHoverBackgroundColor: gradient2,
                                    pointHoverBorderColor: gradient2,
                                    pointBorderWidth: 2,
                                    pointHoverBorderWidth: 1,
                                    tension: 0.3,
                                    stacked: false,
                                    data : [25, 75, 30, 125, 80, 115, 150]
                                },
                                {
                                    fill: "true",
                                    label: "SUPPORT",
                                    backgroundColor: "transparent",
                                    borderWidth: 3,
                                    borderColor: gradient1,
                                    pointBorderColor: gradient1,
                                    pointBackgroundColor: gradient1,
                                    pointHoverBackgroundColor: gradient1,
                                    pointHoverBorderColor: gradient1,
                                    pointBorderWidth: 2,
                                    pointHoverBorderWidth: 1,
                                    tension: 0.3,
                                    stacked: false,
                                    data : [5, 50, 40, 90, 100, 60, 90]
                                }
                            ]
                        }

                        var line_ctx = document.getElementById('line-chart').getContext('2d');

                        var line_chart = new Chart(line_ctx, {
                            type: 'line',
                            data: data1,
                            options: options
                        });

                    }

                    // AREA CHART //
                    if ($("#area-chart").length > 0) {

                        var area_ctx = document.getElementById('area-chart').getContext('2d');

                        var gradient1 = area_ctx.createLinearGradient(0,60,850,0);
                        gradient1.addColorStop(1, '#310068');
                        gradient1.addColorStop(0, '#fe005a');

                        var data2 = {
                            labels : ["JAN", "", "FEB", "", "MAR", "", "APR", "", "MAY", "", "JUN", "", "JUL", "", "AUG", "", "SEPT", "", "OCT"],
                            datasets : [
                                {
                                    fill: "true",
                                    label: "2017 SALES",
                                    backgroundColor: gradient1,
                                    borderWidth: 1,
                                    borderColor: gradient1,
                                    pointBorderColor: gradient1,
                                    pointBackgroundColor: "#fff",
                                    pointHoverBackgroundColor: "#fff",
                                    pointHoverBorderColor: gradient1,
                                    pointBorderWidth: 1,
                                    pointHoverBorderWidth: 1,
                                    tension: 0.4,
                                    stacked: false,
                                    data : [100, 150, 75, 120, 90, 150, 130, 220, 60, 110, 90, 230, 150, 170, 70, 100, 35, 180, 100]
                                }
                            ]
                        }

                        var area_chart = new Chart(area_ctx, {
                            type: 'line',
                            data: data2,
                            options: options
                        });

                    }


                    // BAR CHART //
                    if ($("#bar-chart").length > 0) {

                        var area_ctx = document.getElementById('bar-chart').getContext('2d');

                        var data3 = {
                            labels : ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
                            datasets : [
                                {
                                    label: "Profit",
                                    backgroundColor: "#fe005a",
                                    borderColor: "transparent",
                                    borderWidth: 3,
                                    hoverBorderWidth: 3,
                                    hoverBackgroundColor: "#fe005a",
                                    hoverBorderColor: "#fff",
                                    data : [95, 140, 110, 150, 140, 130, 175, 75, 125, 80, 115, 150]
                                },
                                {
                                    label: "Revenue",
                                    backgroundColor: "#310068",
                                    borderColor: "transparent",
                                    borderWidth: 3,
                                    hoverBorderWidth: 3,
                                    hoverBackgroundColor: "#310068",
                                    hoverBorderColor: "#fff",
                                    data : [25, 75, 30, 125, 80, 115, 150, 100, 150, 75, 120, 90, 150]
                                }
                            ]
                        }

                        var bar_chart = new Chart(area_ctx, {
                            type: 'bar',
                            data: data3,
                            options: options
                        });

                    }

                    // PIE CHART //
                    if ($("#pie-chart").length > 0) {

                        var area_ctx = document.getElementById('pie-chart').getContext('2d');

                        var data4 = {
                            labels: [
                                "Credibility",
                                "Sustenability",
                                "Economy"
                            ],
                            datasets: [
                                {
                                    data: [60, 25, 15],
                                    borderWidth: 0,
                                    backgroundColor: [
                                        "#fe005a",
                                        "#310068",
                                        "#f40b4c"
                                    ],
                                    hoverBackgroundColor: [
                                        "#fe005a",
                                        "#310068",
                                        "#f40b4c"
                                    ]
                                }]
                        };

                        var pie_chart = new Chart(area_ctx, {
                            type: 'pie',
                            data: data4
                        });

                    }


                    // DOUGHNUT CHART //
                    if ($("#doughnut-chart").length > 0) {

                        var area_ctx = document.getElementById('doughnut-chart').getContext('2d');

                        var data5 = {
                            labels: [
                                "Credibility",
                                "Sustenability",
                                "Economy"
                            ],
                            datasets: [
                                {
                                    data: [60, 25, 15],
                                    borderWidth: 0,
                                    backgroundColor: [
                                        "#fe005a",
                                        "#310068",
                                        "#f40b4c"
                                    ],
                                    hoverBackgroundColor: [
                                        "#fe005a",
                                        "#310068",
                                        "#f40b4c"
                                    ]
                                }]
                        };

                        var doughnut_chart = new Chart(area_ctx, {
                            type: 'doughnut',
                            data: data5,
                            options: {
                                cutoutPercentage: 80,
                            }
                        });

                    }

                }

            });

        }

    }


    // RADIAL BAR CHART //
    function radial_bar_chart() {

        $(".radial-bar-chart:in-viewport").each(function() {

            if(!$(this).hasClass("animated")) {

                $(this).addClass("animated");

                var radial_bar_chart = $(".radial-bar-chart").radialMultiProgress("init", {
                    'size': 180,
                    'fill': 80,
                    'font-size': 14,
                    "background": "transparent",
                    "text-color": "transparent",
                    'data': [
                        {'color': "#310068"},
                        {'color': "#650263"},
                        {'color': "#9a0360"},
                        {'color': "#d5045c"},
                        {'color': "#fe005a"}
                    ]
                });

                var start_radial_bar_chart = function () {
                    setInterval(function () {
                        radial_bar_chart.radialMultiProgress("to", {
                            "index": 0, 'perc': 75, 'time': 500
                        });
                        radial_bar_chart.radialMultiProgress("to", {
                            "index": 1, 'perc': 71, 'time': 500
                        });
                        radial_bar_chart.radialMultiProgress("to", {
                            "index": 2, 'perc': 73, 'time': 500
                        });
                        radial_bar_chart.radialMultiProgress("to", {
                            "index": 3, 'perc': 74, 'time': 500
                        });
                        radial_bar_chart.radialMultiProgress("to", {
                            "index": 4, 'perc': 72, 'time': 500
                        });
                    }, 1000);
                };

                start_radial_bar_chart();

            }

        });

    }


    // LOAD MORE PROJECTS //
    function load_more_projects() {

        var number_clicks = 0;

        $(".load-more").on("click", function(e) {

            e.preventDefault();

            if (number_clicks == 0) {
                $.ajax({
                    type: "POST",
                    url: $(".load-more").attr("href"),
                    dataType: "html",
                    cache: false,
                    msg : '',
                    success: function(msg) {
                        $(".isotope").append(msg);
                        $(".isotope").imagesLoaded(function() {
                            $(".isotope").isotope("reloadItems").isotope();
                            $(".fancybox").fancybox({
                                prevEffect: 'none',
                                nextEffect: 'none',
                                padding: 0
                            });
                        });
                        number_clicks++;
                        $(".load-more").html("Nothing to load");
                    }
                });
            }

        });

    }


    // SHOW/HIDE SCROLL UP //
    function show_hide_scroll_top() {

        if ($(window).scrollTop() > $(window).height()/2) {
            $("#scroll-up").fadeIn(300);
        } else {
            $("#scroll-up").fadeOut(300);
        }

    }


    // SCROLL UP //
    function scroll_up() {

        $("#scroll-up").on("click", function() {
            $("html, body").animate({
                scrollTop: 0
            }, 800);
            return false;
        });

    }


    // INSTAGRAM FEED //
    function instagram_feed() {

        if ((typeof Instafeed !== 'undefined') & ($("#instafeed").length > 0)) {

            var nr = $("#instafeed").data('number');
            var userid = $("#instafeed").data('user');
            var accesstoken = $("#instafeed").data('accesstoken');

            var feed = new Instafeed({
                target: 'instafeed',
                get: 'user',
                userId: userid,
                accessToken: accesstoken,
                limit: nr,
                resolution: 'thumbnail',
                sortBy: 'most-recent',
                after: function() {
                    $('#instafeed a').attr('target','_blank');
                }
            });

            feed.run();

        }

    }


    // ANIMATIONS //
    function animations() {

        if (typeof WOW !== 'undefined') {

            animations = new WOW({
                boxClass: 'wow',
                animateClass: 'animated',
                offset: 100,
                mobile: false,
                live: true
            });

            animations.init();

        }

    }


    // MULTILAYER PARALLAX //
    function multilayer_parallax() {

        $(".multilayer-parallax .parallax-layer").each(function(){

            var x = parseInt($(this).attr("data-x"), 10),
                y = parseInt($(this).attr("data-y"), 10);

            $(this).css({
                "left": x + "%",
                "top": y + "%"
            });

        });

    }


    // FULL SECTIONS OVERLAY //
    function full_sections_overlay() {

        $(".full-section-overlay").each(function () {
            $(this).css({
                "opacity": $(this).data("overlay-opacity") / 100,
                "background": $(this).data("overlay-color")
            });
        })

    }

    // DOCUMENT READY //
    $(document).ready(function(){


        $('html,body').animate({
            scrollTop: $(window).scrollTop() + 1
        }, 1000);

        // STICKY //
        if ($("body").hasClass("sticky-header")) {
            sticky();
        }


        // MENU //
        if (typeof $.fn.superfish !== 'undefined') {

            $(".menu").superfish({
                popUpSelector: 'ul:not(.secondary-menu),.megamenu-container',
                delay: 500,
                animation: {
                    opacity: 'show',
                    height: 'show'
                },
                speed: 'fast',
                autoArrows: true
            });

        }


        // SECONDARY MENU //
        secondary_menu();


        // MENU SLIDE //
        menu_slide();


        // SHOW/HIDE MOBILE MENU //
        show_hide_mobile_menu();


        // MOBILE MENU //
        mobile_menu();


        // SEARCH //
        header_search();


        // FANCYBOX //
        if (typeof $.fn.fancybox !== 'undefined') {

            $(".fancybox").fancybox({
                prevEffect: 'none',
                nextEffect: 'none',
                padding: 0
            });

        }

        // REVOLUTION SLIDER //
        if (typeof $.fn.revolution !== 'undefined') {

            $(".rev_slider").revolution({
                sliderType: "standard",
                sliderLayout: "auto",
                delay: 2500,
                spinner: 'none',
                onHoverStop: 'off',
                navigation: {
                    onHoverStop: 'off',
                    arrows:{
                        style: "custom",
                        enable: true,
                        hide_onmobile: true,
                        hide_onleave: false,
                        hide_delay: 200,
                        hide_delay_mobile: 1200,
                        hide_under: 0,
                        hide_over: 9999,
                        tmp: '',
                        left: {
                            h_align: "left",
                            v_align: "center",
                            h_offset: 20,
                            v_offset: 0
                        },
                        right: {
                            h_align: "right",
                            v_align: "center",
                            h_offset: 20,
                            v_offset: 0
                        }
                    },
                    bullets:{
                        style: "custom",
                        enable: true,
                        hide_onmobile: false,
                        hide_onleave: false,
                        hide_delay: 200,
                        hide_delay_mobile: 1200,
                        hide_under: 0,
                        hide_over: 9999,
                        tmp: '',
                        direction: "horizontal",
                        space: 15,
                        h_align: "center",
                        v_align: "bottom",
                        h_offset: 0,
                        v_offset: 40
                    },
                    touch:{
                        touchenabled: "on",
                        swipe_treshold: 75,
                        swipe_min_touches: 1,
                        drag_block_vertical: false,
                        swipe_direction: "horizontal"
                    }
                },
                gridwidth: 1830,
                gridheight: 935
            });

        }


        // OWL Carousel //
        if (typeof $.fn.owlCarousel !== 'undefined') {

            // IMAGES SLIDER //
            $(".owl-carousel.images-slider").owlCarousel({
                items: 1,
                autoplay: true,
                autoplayTimeout: 3000,
                autoplayHoverPause: false,
                smartSpeed: 1200,
                loop: true,
                nav: true,
                navText: false,
                dots: true,
                mouseDrag: true,
                touchDrag: true,
                animateIn: 'fadeIn',
                animateOut: 'fadeOut'
            });

            // IMAGES SLIDER VERTICAL //
            $(".owl-carousel.images-slider-vertical").owlCarousel({
                items: 1,
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: false,
                touchDrag: true,
                animateIn: 'slideInDown',
                animateOut: 'slideOutDown'
            });

            // LOGOS SLIDER //
            $(".owl-carousel.logos-slider").owlCarousel({
                autoplay: true,
                autoplayTimeout: 3000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: true,
                navText: false,
                dots: false,
                mouseDrag: true,
                touchDrag: true,
                responsive: {
                    0:{
                        items: 1
                    },
                    480:{
                        items: 2
                    },
                    768:{
                        items: 3
                    },
                    992:{
                        items: 4
                    },
                    1200:{
                        items: 5
                    }
                }
            });


            // BLOG ARTICLES SLIDER //
            $(".owl-carousel.blog-articles-slider").owlCarousel({
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: true,
                navText: ["Prev", "Next"],
                dots: true,
                mouseDrag: true,
                touchDrag: true,
                margin: 30,
                responsive: {
                    0:{
                        items: 1
                    },
                    480:{
                        items: 3
                    },
                    992:{
                        items: 5
                    }
                }
            });


            // TESTIMONIALS CAROUSEL //
            $(".owl-carousel.testimonials-carousel").owlCarousel({
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: true,
                touchDrag: true,
                margin: 30,
                responsive: {
                    0:{
                        items: 1
                    },
                    768:{
                        items: 2
                    },
                    992:{
                        items: 3
                    }
                }
            });

            // TESTIMONIALS SLIDER //
            $(".owl-carousel.testimonials-slider").owlCarousel({
                items: 1,
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: true,
                touchDrag: true
            });


            // TESTIMONIALS SLIDER 2 //
            $(".owl-carousel.testimonials-slider-2").owlCarousel({
                items: 1,
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: true,
                touchDrag: true,
                animateIn: 'fadeIn',
                animateOut: 'fadeOut'
            });

            // TESTIMONIALS SLIDER VERTICAL //
            $(".owl-carousel.testimonials-slider-vertical").owlCarousel({
                items: 1,
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                smartSpeed: 1200,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: false,
                touchDrag: true,
                animateIn: 'slideInDown',
                animateOut: 'slideOutDown'
            });

            // SERVICES BOXES CAROUSEL //
            $(".owl-carousel.services-boxes-carousel").owlCarousel({
                autoplay: true,
                autoplayTimeout: 3000,
                autoplayHoverPause: true,
                smartSpeed: 500,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: true,
                touchDrag: true,
                margin: 50,
                responsive: {
                    0:{
                        items: 1
                    },
                    480:{
                        items: 2
                    },
                    768:{
                        items: 3
                    },
                    1200:{
                        items: 4
                    }
                }
            });

            // APP CAROUSEL //
            $(".owl-carousel.app-carousel").owlCarousel({
                autoplay: true,
                autoplayTimeout: 4000,
                autoplayHoverPause: true,
                smartSpeed: 500,
                loop: true,
                nav: false,
                navText: false,
                dots: true,
                mouseDrag: true,
                touchDrag: true,
                center: true,
                margin: 10,
                responsive: {
                    0:{
                        items: 1
                    },
                    768:{
                        items: 3
                    },
                    1200:{
                        items: 5
                    }
                }
            });

        }


        // FEATURE CAROUSEL //
        if ((typeof $.fn.waterwheelCarousel !== 'undefined') && ($(".features-carousel").length > 0)) {

            var separation_value = 70;

            if ($(window).width() >= 1400) { separation_value = 450 }
            if (($(window).width() >= 1200) && ($(window).width() < 1400)) { separation_value = 330 }
            if (($(window).width() >= 992) && ($(window).width() < 1200)) { separation_value = 250 }
            if (($(window).width() >= 768) && ($(window).width() < 992)) { separation_value = 175 }
            if (($(window).width() >= 575) && ($(window).width() < 768)) { separation_value = 140 }

            $(".features-carousel").waterwheelCarousel({
                startingItem: 1,
                opacityMultiplier: 1,
                separation: separation_value,
                flankingItems: 2,
                sizeMultiplier: 0.8,
                autoPlay: 5000,
                speed: 200
            });

        }

        // PHONE CAROUSEL //
        if ((typeof $.fn.waterwheelCarousel !== 'undefined') && ($(".phone-carousel").length > 0)) {

            var separation_value = 70,
                flanking_items = 2;

            if ($(window).width() < 767) {
                flanking_items = 1;
            }

            if (($(window).width() >= 768) && ($(window).width() < 992)) {
                separation_value = 175
            } else {
                separation_value = 200;
            }

            $(".phone-carousel").waterwheelCarousel({
                startingItem: 1,
                opacityMultiplier: 1,
                separation: separation_value,
                flankingItems: flanking_items,
                sizeMultiplier: 0.85,
                autoPlay: 5000,
                speed: 200
            });

        }


        // GOOGLE MAPS //
        if (typeof $.fn.gmap3 !== 'undefined') {

            $(".map").each(function() {

                var data_zoom = 15,
                    data_height,
                    data_popup = false;

                if ($(this).attr("data-zoom") !== undefined) {
                    data_zoom = parseInt($(this).attr("data-zoom"),10);
                }

                if ($(this).attr("data-height") !== undefined) {
                    data_height = parseInt($(this).attr("data-height"),10);
                }

                if ($(this).attr("data-address-details") !== undefined) {

                    data_popup = true;

                    var infowindow = new google.maps.InfoWindow({
                        content: $(this).attr("data-address-details")
                    });

                }


                $(this)
                    .gmap3({
                        address: $(this).attr("data-address"),
                        zoom: data_zoom,
                        mapTypeId: google.maps.MapTypeId.ROADMAP,
                        scrollwheel: false
                    })
                    .marker([
                        {address: $(this).attr("data-address")}
                    ])
                    .on({
                        click: function(marker, event){
                            if (data_popup) {
                                infowindow.open(marker.get('map'), marker);
                            }
                        }
                    });

                $(this).css("height", data_height + "px");

            });

        }


        // ISOTOPE //
        if ((typeof $.fn.imagesLoaded !== 'undefined') && (typeof $.fn.isotope !== 'undefined')) {

            $(".isotope").imagesLoaded( function() {

                var container = $(".isotope");

                container.isotope({
                    itemSelector: '.isotope-item',
                    layoutMode: 'masonry',
                    transitionDuration: '0.8s'
                });

                $(".filter li a").on("click", function() {
                    $(".filter li a").removeClass("active");
                    $(this).addClass("active");

                    var selector = $(this).attr("data-filter");
                    container.isotope({
                        filter: selector
                    });

                    return false;
                });

                $(window).resize(function() {
                    container.isotope();
                });

            });

        }


        // LOAD MORE PORTFOLIO ITEMS //
        load_more_projects();


        // CONTACT FORM VALIDATE & SUBMIT //
        // VALIDATE //
        if (typeof $.fn.validate !== 'undefined') {

            $("#contact-form").validate({
                rules: {
                    name: {
                        required: true
                    },
                    email: {
                        required: true,
                        email: true
                    },
                    subject: {
                        required: true
                    },
                    message: {
                        required: true,
                        minlength: 3
                    }
                },
                messages: {
                    name: {
                        required: "Please enter your name!"
                    },
                    email: {
                        required: "Please enter your email!",
                        email: "Please enter a valid email address"
                    },
                    subject: {
                        required: "Please enter the subject!"
                    },
                    message: {
                        required: "Please enter your message!"
                    }
                },

                // SUBMIT //
                submitHandler: function(form) {
                    var result;
                    $(form).ajaxSubmit({
                        type: "POST",
                        data: $(form).serialize(),
                        url: "assets/php/send.php",
                        success: function(msg) {

                            if (msg == 'OK') {
                                result = '<div class="alert alert-success">Your message was successfully sent!</div>';
                                $("#contact-form").clearForm();
                            } else {
                                result = msg;
                            }

                            $("#alert-area").html(result);

                        },
                        error: function() {

                            result = '<div class="alert alert-danger">There was an error sending the message!</div>';
                            $("#alert-area").html(result);

                        }
                    });
                }
            });

        }


        // PARALLAX //
        if (typeof $.fn.stellar !== 'undefined') {

            // MULTILAYER PARALLAX //
            multilayer_parallax();

            if (!is_touch_device()) {

                $(window).stellar({
                    horizontalScrolling: false,
                    verticalScrolling: true,
                    responsive: true
                });

            } else {

                $(".parallax").addClass("parallax-disable");

            }

        }


        // SHOW/HIDE SCROLL UP
        show_hide_scroll_top();


        // SCROLL UP //
        scroll_up();


        // PROGRESS BARS //
        progress_bars();


        // PIE CHARTS //
        pie_chart();


        // COUNTER //
        counter();


        // ODOMETER //
        odometer();


        // STATISTICS //
        statistics();


        // RADIAL BAR CHART //
        radial_bar_chart();


        // YOUTUBE PLAYER //
        if (typeof $.fn.mb_YTPlayer !== 'undefined') {

            $(".youtube-player").mb_YTPlayer();

        }


        // INSTAGRAM FEED //
        instagram_feed();


        // TWITTER //
        if(typeof twitterFetcher !== 'undefined' && ($('.widget-twitter').length > 0)) {

            $('.widget-twitter').each(function(index){

                var account_id = $('.tweets-list', this).attr('data-account-id'),
                    items = $('.tweets-list', this).attr('data-items'),
                    newID = 'tweets-list-' + index;

                $('.tweets-list', this).attr('id', newID);

                var config = {
                    "id": account_id,
                    "domId": newID,
                    "maxTweets": items,
                    "showRetweet": false,
                    "showTime": false,
                    "showUser": false,
                    "showInteraction": false
                };

                twitterFetcher.fetch(config);
            });

        }


        // COUNTDOWN //
        if (typeof $.fn.countdown !== 'undefined') {

            $(".countdown").countdown('2019/08/01 00:00', function(event) {
                $(this).html(event.strftime(
                    '<div><span class="count">%-D</span><span>Days</span></div>' +
                    '<div><span class="count">%-H</span><span>H</span></div>' +
                    '<div><span class="count">%-M</span><span>M</span></div>' +
                    '<div><span class="count">%S</span><span>S</span></div>'
                ));
            });

        }


        // ANIMATIONS //
        animations();


        // FULL SECTIONS OVERLAY //
        full_sections_overlay();


        // FULLPAGE //
        if (typeof $.fn.fullpage !== 'undefined') {

            $('.fullpage').fullpage({
                scrollBar: true,
                fitToSection: false,
                scrollOverflow: true,
                keyboardScrolling: false,
                navigation: true,
                hybrid:true,
                sectionSelector: '.fullpage-section',
                afterLoad: function() {
                    if ($(".fullpage").hasClass('numbers-nav')) {
                        $("#fp-nav").addClass('numbers-nav');
                    }
                }
            });

        }


        // POPOVER //
        if (typeof $.fn.popover !== 'undefined') {
            $('[data-toggle="popover"]').popover();
        }


    });


    // WINDOW SCROLL //
    $(window).scroll(function() {

        progress_bars();
        pie_chart();
        counter();
        odometer();
        statistics();
        radial_bar_chart();
        show_hide_scroll_top();

    });


    // WINDOW RESIZE //
    $(window).resize(function() {

        mobile_menu();

    });

})(window.jQuery);