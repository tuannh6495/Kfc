// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/*Js cho Body*/
const slider = document.querySelector('.slide-banner');
const slides = document.querySelector('.banner');
const prevButton = document.querySelector('.prev');
const nextButton = document.querySelector('.next');

let currentIndex = 0;

function showSlide(index) {
    slides.style.transform = `translateX(-${index * 100}%)`;
}

prevButton.addEventListener('click', () => {
    currentIndex = (currentIndex - 1 + slides.children.length) % slides.children.length;
    showSlide(currentIndex);
});

nextButton.addEventListener('click', () => {
    currentIndex = (currentIndex + 1) % slides.children.length;
    showSlide(currentIndex);
});

function autoSlide() {
    nextSlide();
}

let slideInterval = setInterval(autoSlide, 3000);

