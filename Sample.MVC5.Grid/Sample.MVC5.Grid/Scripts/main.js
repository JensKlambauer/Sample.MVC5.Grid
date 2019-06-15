$.datepicker.regional['de'] =
{
    clearText: 'löschen',
    clearStatus: 'aktuelles Datum löschen',
    closeText: 'schließen',
    closeStatus: 'ohne Änderungen schließen',
    prevText: '<zurück',
    prevStatus: 'letzten Monat zeigen',
    nextText: 'Vor>',
    nextStatus: 'nächsten Monat zeigen',
    currentText: 'heute',
    currentStatus: '',
    monthNames: ['Januar', 'Februar', 'März', 'April', 'Mai', 'Juni', 'Juli', 'August', 'September', 'Oktober', 'November', 'Dezember'],
    monthNamesShort: ['Jan', 'Feb', 'Mär', 'Apr', 'Mai', 'Jun', 'Jul', 'Aug', 'Sep', 'Okt', 'Nov', 'Dez'],
    monthStatus: 'anderen Monat anzeigen',
    yearStatus: 'anderes Jahr anzeigen',
    weekHeader: 'Wo',
    weekStatus: 'Woche des Monats',
    dayNames: ['Sonntag', 'Montag', 'Dienstag', 'Mittwoch', 'Donnerstag', 'Freitag', 'Samstag'],
    dayNamesShort: ['So', 'Mo', 'Di', 'Mi', 'Do', 'Fr', 'Sa'],
    dayNamesMin: ['So', 'Mo', 'Di', 'Mi', 'Do', 'Fr', 'Sa'],
    dayStatus: 'Setze DD als ersten Wochentag',
    dateStatus: 'Wähle D, M d',
    dateFormat: 'dd.mm.yy',
    firstDay: 1,
    initStatus: 'Wähle ein Datum',
    isRTL: false
};

$.datepicker.setDefaults($.datepicker.regional['de']);

MvcGrid.prototype.lang = {
    text: {
        'contains': 'Enthält',
        'equals': 'Gleich',
        'not-equals': 'Ungleich',
        'starts-with': 'Beginnt mit',
        'ends-with': 'Endet mit'
    },
    number: {
        'equals': 'Gleich',
        'not-equals': 'Ungleich',
        'less-than': 'kleiner als',
        'greater-than': 'größer als',
        'less-than-or-equal': 'kleiner oder gleich',
        'greater-than-or-equal': 'größer oder gleich'
    },
    date: {
        'equals': 'Gleich',
        'not-equals': 'Ungleich',
        'earlier-than': 'Früher als',
        'later-than': 'Später als',
        'earlier-than-or-equal': 'Früher oder gleich',
        'later-than-or-equal': 'Später oder gleich'
    },
    enum: {
        'equals': 'Gleich',
        'not-equals': 'Ungleich'
    },
    boolean: {
        'equals': 'Gleich',
        'not-equals': 'Ungleich'
    },
    guid: {
        'equals': 'Gleich',
        'not-equals': 'Ungleich'
    },
    filter: {
        'apply': '&#10004;',
        'remove': '&#10008;'
    },
    operator: {
        'select': '',
        'and': 'und',
        'or': 'oder'
    }
};
