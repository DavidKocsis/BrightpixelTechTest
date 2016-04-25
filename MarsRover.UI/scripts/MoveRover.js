function moveRover() {
    $.ajax({
        url: 'http://localhost:50644/api/v1/values/MoveRovers?X=1&Y=2&Direction=N&Movements=LMLMLMLMM',
        type: 'GET',
        dataType: 'jsonp',
        success: function(data) {
            alert(data);
        },
        error: function(x, y, data) {
            alert(x + '\n' + y + '\n' + data);
        }
    });
}