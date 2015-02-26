function changeSlide() {
    var $currentSlide = $('.carousel-slide.visible');
    var $slides = $('.carousel-slide');
    $slides.removeClass('visible');
    var index = $slides.index($currentSlide);
    index = (index < $slides.length - 1) ? index + 1 : 0;
    $slides.eq(index).addClass('visible');
}

$(function () {
    $('.carousel-slide:first-child').addClass('visible');
    window.setInterval(changeSlide, 3000);
});