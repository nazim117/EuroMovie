document.getElementById('showRatingButton').addEventListener('click', function () {
    var ratingSection = document.getElementById('ratingSection');
    ratingSection.style.display =
        (ratingSection.style.display == 'none' || ratingSection.style.display == '') ? 'block' : 'none';
});