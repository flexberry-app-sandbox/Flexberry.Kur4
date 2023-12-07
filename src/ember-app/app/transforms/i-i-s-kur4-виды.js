import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ВидыEnum from '../enums/i-i-s-kur4-виды';

export default FlexberryEnum.extend({
  enum: ВидыEnum,
  sourceType: 'IIS.Kur4.Виды'
});
