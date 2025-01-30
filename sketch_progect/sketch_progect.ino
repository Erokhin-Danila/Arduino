#include <Arduino.h>
#define PIN_LED 13
#define PIN_SENSOR 2 // Пин, к которому присоединен датчик вибрации

char commandValue; // данные, поступаемые с последовательного порта

void setup() {
  // Инициализация последовательного порта для вывода журнала событий
  Serial.begin(9600);
  pinMode(PIN_LED, OUTPUT); // режим на вывод данных
}

void loop() {
  int val = digitalRead(PIN_SENSOR); // Считываем значение с датчика
  
  if (Serial.available()) {
    commandValue = Serial.read();
  }

  if(commandValue == '1')
  {
    if(val == 0)
    {
      digitalWrite(PIN_LED, HIGH); // Датчик сработад - включаем светодиод
    }
  }
  else
  {
    digitalWrite(PIN_LED, LOW);
  }
  delay(10); // задержка перед следующим чтением данных
}