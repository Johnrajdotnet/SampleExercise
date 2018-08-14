

InputAutoSerach = function (data) {
    debugger;
    response($.map(data, function (item) {
        return { label: item.CityName, value: item.CityName };
    }))
}