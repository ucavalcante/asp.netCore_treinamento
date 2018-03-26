var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
//var uncss = require('gulp-uncss');

gulp.task('js', function () {
   
    return gulp.src([
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery/dist/jquery.min.js'
    ])
    .pipe(gulp.dest('wwwroot/js/'));
});

gulp.task('css',function(){

    return gulp.src([
        './Styles/site.css',
        './node_modules/bootstrap/dist/css/bootstrap.css'
    ])
    .pipe(concat('site.min.css'))
    .pipe(cssmin())
    //.pipe(uncss({html:['Views/**/*.cshtml']}))
    .pipe(gulp.dest('wwwroot/css/'));
});

gulp.task('watch-css', function(){
    gulp.watch('./Styles/**/*.css',['css'])
})