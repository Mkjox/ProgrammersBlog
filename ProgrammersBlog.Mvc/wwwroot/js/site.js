function convertFirstLetterToUpperCase(text) {
    return text.charAt(0).toUpperCase() + text.slice(1);
}
function convertToShortDate(dateString) {
    const shortDate = new Date(dateString).toLocalDateString('en-US');
    return shortDate;
}