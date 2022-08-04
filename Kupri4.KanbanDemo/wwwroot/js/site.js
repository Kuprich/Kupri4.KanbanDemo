function onBlazorReady() {

    Sortable.create(column_0, {
        group: "shared",
        animation: 150,
        ghostClass: 'blue-background-class'
    });
    Sortable.create(column_1, {
        group: "shared",
        animation: 150,
        ghostClass: 'blue-background-class'
    });
    Sortable.create(column_2, {
        group: "shared",
        animation: 150,
        ghostClass: 'blue-background-class'
    });

}