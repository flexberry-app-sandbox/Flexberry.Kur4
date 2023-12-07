import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ПитанияEnum from '../enums/i-i-s-kur4-питания';

export default FlexberryEnum.extend({
  enum: ПитанияEnum,
  sourceType: 'IIS.Kur4.Питания'
});
