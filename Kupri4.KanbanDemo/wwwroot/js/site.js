function onBlazorReady() {

    let colums = [column_0, column_1, column_2]

    for (var i = 0; i < colums.length; ++i) {
       
        Sortable.create(colums[i], {
            group: "shared",
            animation: 150,
            ghostClass: 'blue-background-class',
        })
    }
    
}