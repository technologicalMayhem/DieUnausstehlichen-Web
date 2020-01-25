//Scroll back to top
const scrollToTop = () => {
    const c = document.documentElement.scrollTop || document.body.scrollTop;
    if (c > 0) {
        window.requestAnimationFrame(scrollToTop);
        window.scrollTo(0, c - c / 8);
    }
};
window.onscroll = function() {scrollFunction()};
//Make the button appear and disappear
function scrollFunction() {
    if (document.body.scrollTop > 250 || document.documentElement.scrollTop > 250) {
        toTopButton.style.display = "block";
        $("#toTopButton").removeClass("slideOutDown").addClass("slideInUp");
    } else {
        //toTopButton.style.display = "none";
        $("#toTopButton").removeClass("slideInUp").addClass("slideOutDown");
    }
}