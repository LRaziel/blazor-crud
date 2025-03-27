window.initDropdowns = () => {
    var dropdowns = document.querySelectorAll('.dropdown-toggle');
    dropdowns.forEach((dropdown) => {
        new bootstrap.Dropdown(dropdown);
    });
};
