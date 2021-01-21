using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHW
{
    class MyDictionary<TKey, TValue>  //bu sınıfın hangi tiplerde çalışacağını belirttik
    {
        TKey[] keys;    //tanımladık ama onlara referans adresleri alabilmemiz için newlememiz gerekiyor.
        TValue[] values;

        public MyDictionary()         //0 elemanlı diziler oluşturduk ki eleman ekleyebilelim
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKeys = keys;   //geçiçi olarak referansları tempKeyse tutturuyoruz ki kaybolmasın

            TValue[] _tempValues = values; //değer kaybolmasın diye saklama işlemi

            keys = new TKey[keys.Length + 1];  //diziye eleman ekleyebilmek için eleman sayısını birer arttırma işlemi

            values = new TValue[values.Length + 1]; //valuesın eleman sayısını arttırma işlemi

            for (int i = 0; i < _tempKeys.Length; i++) //döngü içerisinde değerleri aktarma işlemi
            {
                keys[i] = _tempKeys[i]; //tuttuğu değerleri keyse geri alıyoruz
                values[i] = _tempValues[i]; //tuttuğu değerleri valuesa geri alıyoruz
            }

            keys[keys.Length - 1] = key;   //son eklenen elemanı da ekleme işlemi
            values[values.Length - 1] = value; //son eklenen elemanı ekleme işlemi

        }
        public TKey[] Keys        //yalnızca get işleminin gerçekleştirildiği blok
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }

    }

    
}
