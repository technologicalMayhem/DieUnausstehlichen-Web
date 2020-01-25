// Makes the navbar scroll
// window.onscroll = function() {myFunction()};
//
// function myFunction() {
//     var navbar = document.getElementById("navbar");
//     var sticky = navbar.offsetTop;
//     if (window.pageYOffset >= sticky) {
//         navbar.classList.add("sticky")
//     } else {
//         navbar.classList.remove("sticky");
//     }
// }
const scrollToTop = () => {
    const c = document.documentElement.scrollTop || document.body.scrollTop;
    if (c > 0) {
        window.requestAnimationFrame(scrollToTop);
        window.scrollTo(0, c - c / 8);
    }
};
window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    if (document.body.scrollTop > 250 || document.documentElement.scrollTop > 250) {
        toTopButton.style.display = "block";
        $("#toTopButton").removeClass("slideOutDown").addClass("slideInUp");
    } else {
        //toTopButton.style.display = "none";
        $("#toTopButton").removeClass("slideInUp").addClass("slideOutDown");
    }
}