var gulp = require('gulp');
var concat = require('gulp-concat')

gulp.task('js', function () {
    
    return gulp.src([
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery/dist/jquery.min.js'
    ]).pipe(gulp.dest('wwwroot/js/'))
    ;
});

gulp.task('css',function(){

    return gulp.src()
    
});