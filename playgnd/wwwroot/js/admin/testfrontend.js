function questionsAdd(qInner) {
    document.getElementById('questions').innerHTML = qInner;
}
function answersAdd(aInner, index) {
    document.getElementById('answers' + index).innerHTML = aInner;

}
function questionsAction() {
    var qNum = document.getElementById('totalQue').value;
    var qInner = "";
    for (var i = 0; i < qNum; i++) {
        qInner = qInner + '<label><b>Вопрос ' + i + '</b></label> <input class="question-input" id="q' + i + '" type="text"/><br /><label>Колисествово ответов </label><input class="answers-count" id="a' + i + '" type="number" value="0" /><br /><input class="button" type="button" value="Ввод ответов" onclick="answersAction(' + i + ')" /> <br/><br/><div id="answers' + i + '"> </div><br/><br/>';
    }
    questionsAdd(qInner);
}
function answersAction(index) {
    var ansNum = document.getElementById('a' + index).value;
    var aInner = "";
    for (var j = 0; j < ansNum; j++) {
        aInner = aInner + '<label><b>' + j + '.</b></label> <input class="answer-input" id="' + index + 'option' + j + '" type="text"/> <input id="' + index +'valid' + j + '" type="checkbox" /><br/>';
    }
    answersAdd(aInner, index);
}