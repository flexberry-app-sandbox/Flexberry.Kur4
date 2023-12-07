import { Serializer as ДокументЗаказаSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kur4-документ-заказа';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ДокументЗаказаSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
