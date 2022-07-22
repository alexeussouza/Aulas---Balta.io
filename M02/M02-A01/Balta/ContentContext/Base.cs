using System;
using Balta.NotificationContext;

namespace Balta.ContentContext{

    // Content é uma classe abstrata, Course, Lecture e Career são do tipo Content
    // Abstract não permite que esta classe seja instanciada
    public abstract class Base : Notifiable
    { 

        public Guid Id { get; set; }

        public Base()
        {
           // Guid globally unique identifier GUID, geração do Id na chamada do construtor
           // É incorreto usar new Guid(), desta forma ele inicia o Id com um numero inteiro com zero
           // Guid.NewGuid() cria um hash de 32 caracteres para o ID, no seguinte formato 64dca407-778c-48a2-839d-97552832fcd7
           // forma de SPOF ponto unico de falha
           Id = Guid.NewGuid(); 
        }
    }
}