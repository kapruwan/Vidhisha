// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function(){
	var footer = document.querySelector('.footer');
	var main = document.querySelector('.main-content');
	function updateFooterSpace(){
		if (!footer) return;
		var h = footer.offsetHeight || 120;
		document.documentElement.style.setProperty('--footer-height', h + 'px');
		if (main) main.style.paddingBottom = h + 'px';
	}
	updateFooterSpace();
	window.addEventListener('resize', updateFooterSpace);
});
