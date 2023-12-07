import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  датаДокумента: DS.attr('date'),
  заказОтправ: DS.attr('boolean'),
  заказПолучен: DS.attr('boolean'),
  заказСобран: DS.attr('boolean'),
  кодДокумента: DS.attr('number'),
  сумма: DS.attr('number'),
  контрагенты: DS.belongsTo('i-i-s-kur4-контрагенты', { inverse: null, async: false }),
  питание: DS.belongsTo('i-i-s-kur4-питание', { inverse: null, async: false }),
  сотрудники: DS.belongsTo('i-i-s-kur4-сотрудники', { inverse: null, async: false })
});

export let ValidationRules = {
  датаДокумента: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.датаДокумента.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  заказОтправ: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.заказОтправ.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  заказПолучен: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.заказПолучен.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  заказСобран: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.заказСобран.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  кодДокумента: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.кодДокумента.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  сумма: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.сумма.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  контрагенты: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.контрагенты.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  питание: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.питание.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  сотрудники: {
    descriptionKey: 'models.i-i-s-kur4-документ-заказа.validations.сотрудники.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ДокументЗаказаE', 'i-i-s-kur4-документ-заказа', {
    кодДокумента: attr('Код документа', { index: 0 }),
    датаДокумента: attr('Дата документа', { index: 1 }),
    сумма: attr('Сумма', { index: 2 }),
    заказСобран: attr('Заказ собран', { index: 3 }),
    заказОтправ: attr('Заказ отправлен', { index: 4 }),
    заказПолучен: attr('Заказ получен', { index: 5 })
  });

  modelClass.defineProjection('ДокументЗаказаL', 'i-i-s-kur4-документ-заказа', {
    кодДокумента: attr('Код документа', { index: 0 }),
    датаДокумента: attr('Дата документа', { index: 1 }),
    сумма: attr('Сумма', { index: 2 }),
    заказСобран: attr('Заказ собран', { index: 3 }),
    заказОтправ: attr('Заказ отправлен', { index: 4 }),
    заказПолучен: attr('Заказ получен', { index: 5 }),
    питание: belongsTo('i-i-s-kur4-питание', 'Код питания', {
      кодПитания: attr('Код питания', { index: 6 }),
      видПитания: attr('Вид питания', { index: 7 })
    }, { index: -1, hidden: true }),
    контрагенты: belongsTo('i-i-s-kur4-контрагенты', 'Код контрагента', {
      кодКонтиагента: attr('Код контрагента', { index: 8 }),
      наименование: attr('Наименование контрагента', { index: 9 })
    }, { index: -1, hidden: true }),
    сотрудники: belongsTo('i-i-s-kur4-сотрудники', 'Фамилия сотрудника', {
      фамилия: attr('Фамилия сотрудника', { index: 10 }),
      имя: attr('Имя сотрудника', { index: 11 }),
      отчество: attr('Отчество сотрудника', { index: 12 }),
      должности: belongsTo('i-i-s-kur4-должности', '', {
        наименование: attr('Должность', { index: 13 })
      }, { index: -1, hidden: true })
    }, { index: -1, hidden: true })
  });
};
